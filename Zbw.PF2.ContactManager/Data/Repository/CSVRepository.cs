using System.Globalization;

using CsvHelper;
using CsvHelper.Configuration;

using Zbw.PF2.ContactManager.Core.Errors;
using Zbw.PF2.ContactManager.Data.Maps;
using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Repository;

public class CSVRepository : ICSVRepository
{
    private readonly CsvConfiguration _csvConfig;
    private readonly string _csvDataDirectory;
    private readonly string _customersCsvFile;
    private readonly string _employeesCsvFile;

    /// <summary>
    ///     Initializes a new instance of the <see cref="CSVRepository" /> class and configures CSV settings.
    /// </summary>
    public CSVRepository()
    {
        string profilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string contactManagerPath = Path.Combine(profilePath, ".contact_manager");

        _csvDataDirectory = Path.Join(contactManagerPath);
        _customersCsvFile = Path.Join(_csvDataDirectory, "customers.csv");
        _employeesCsvFile = Path.Join(_csvDataDirectory, "employees.csv");

        _csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true };

        BootstrapRepository();
    }

    /// <summary>
    ///     Retrieves all records based on the passed type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="InvalidOperationException"></exception>
    /// <exception cref="ArgumentException"></exception>
    public IList<T> GetRecords<T>() where T : Person
    {
        CSVErrorStates? health = CheckRepositoryHealth();
        if (health != null)
        {
            throw new InvalidOperationException($"CSV Repository health check failed: {health}");
        }

        string filePath;
        if (typeof(T) == typeof(Customer))
        {
            filePath = _customersCsvFile;
        }
        else if (typeof(T) == typeof(Employee))
        {
            filePath = _employeesCsvFile;
        }
        else
        {
            throw new ArgumentException($"Unsupported record type: {typeof(T).FullName}");
        }

        using StreamReader reader = new(filePath);
        using CsvReader csv = new(reader, _csvConfig);
        RegisterClassMap<T>(csv.Context);

        return csv.GetRecords<T>().ToList();
    }

    public void CreateRecord<T>(T person) where T : Person
    {
        string filePath = GetSourceFile<T>();
        using StreamWriter writer = new(filePath);
        using CsvWriter csvWriter = new(writer, _csvConfig);
        RegisterClassMap<T>(csvWriter.Context);

        csvWriter.WriteRecord(person);
        csvWriter.Flush();
    }

    public void UpdateRecord<T>(T person) where T : Person
    {
        string tempFilePath = Path.GetTempFileName();
        string filePath = GetSourceFile<T>();

        using (StreamReader reader = new(filePath))
        using (StreamWriter writer = new(tempFilePath))
        using (CsvReader csvReader = new(reader, CultureInfo.InvariantCulture))
        using (CsvWriter csvWriter = new(writer, CultureInfo.InvariantCulture))
        {
            RegisterClassMap<T>(csvReader.Context);
            RegisterClassMap<T>(csvWriter.Context);
            csvReader.Read();
            csvReader.ReadHeader();
            csvWriter.WriteHeader<T>();
            csvWriter.NextRecord();

            while (csvReader.Read())
            {
                T record = csvReader.GetRecord<T>() ?? throw new ArgumentNullException("csvReader.GetRecord<T>()");

                // If it's the target record, modify it before writing
                if (record.Id == person.Id)
                {
                    record = person;
                }

                csvWriter.WriteRecord(record);
                csvWriter.NextRecord();
            }
        }

        // Replace the original file with the updated temp file safely
        File.Delete(filePath);
        File.Move(tempFilePath, filePath);
    }

    public T? GetRecord<T>(int id) where T : Person
    {
        string filePath = GetSourceFile<T>();

        using StreamReader reader = new(filePath);
        using CsvReader csv = new(reader, _csvConfig);
        RegisterClassMap<T>(csv.Context);

        return csv.GetRecords<T>().FirstOrDefault(record => record.Id == id);
    }


    /// <summary>
    ///     Checks if the required repository directories and files exist.
    /// </summary>
    /// <returns>A status enum if a resource is missing; otherwise, null.</returns>
    private CSVErrorStates? CheckRepositoryHealth()
    {
        if (!Directory.Exists(_csvDataDirectory))
        {
            return CSVErrorStates.DIRECTORY_DOES_NOT_EXIST;
        }

        if (!File.Exists(_customersCsvFile))
        {
            return CSVErrorStates.CUSTOMER_FILE_DOES_NOT_EXIST;
        }

        if (!File.Exists(_employeesCsvFile))
        {
            return CSVErrorStates.EMPLOYEES_FILE_DOES_NOT_EXIST;
        }

        return null;
    }


    private string GetSourceFile<T>()
    {
        CSVErrorStates? health = CheckRepositoryHealth();
        if (health != null)
        {
            throw new InvalidOperationException($"CSV Repository health check failed: {health}");
        }

        string filePath;
        if (typeof(T) == typeof(Customer))
        {
            filePath = _customersCsvFile;
        }
        else if (typeof(T) == typeof(Employee))
        {
            filePath = _employeesCsvFile;
        }
        else
        {
            throw new ArgumentException($"Unsupported record type: {typeof(T).FullName}");
        }

        return filePath;
    }

    private static void RegisterClassMap<T>(CsvContext context) where T : Person
    {
        if (typeof(T) == typeof(Customer))
            context.RegisterClassMap<CustomerMap>();
        else if (typeof(T) == typeof(Employee))
            context.RegisterClassMap<EmployeeMap>();
    }

    /// <summary>
    ///     Creates the directory and files with headers if they do not exist.
    /// </summary>
    private void BootstrapRepository()
    {
        if (!Directory.Exists(_csvDataDirectory))
        {
            Directory.CreateDirectory(_csvDataDirectory);
        }

        InitializeFileWithHeader<Customer>(_customersCsvFile);
        InitializeFileWithHeader<Employee>(_employeesCsvFile);
    }

    /// <summary>
    ///     Initializes a file with headers if it does not exist
    /// </summary>
    /// <param name="filePath"></param>
    /// <typeparam name="T"></typeparam>
    private void InitializeFileWithHeader<T>(string filePath) where T : Person
    {
        if (!File.Exists(filePath))
        {
            using StreamWriter writer = new(filePath);
            using CsvWriter csv = new(writer, _csvConfig);
            RegisterClassMap<T>(csv.Context);
            csv.WriteHeader<T>();
            csv.NextRecord();
        }
    }
}