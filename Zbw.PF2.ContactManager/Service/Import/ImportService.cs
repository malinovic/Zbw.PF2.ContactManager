using System.Globalization;

using CsvHelper;
using CsvHelper.Configuration;

using vCard.Net.CardComponents;
using vCard.Net.Serialization;

using VCardAddress = vCard.Net.DataTypes.Address;
using VCardTelephone = vCard.Net.DataTypes.Telephone;

using Zbw.PF2.ContactManager.Core.Validation;
using Zbw.PF2.ContactManager.Data.Maps;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Models.Validation;
using Zbw.PF2.ContactManager.Service.Validation;
using Zbw.PF2.ContactManager.Validation.ValidationCustomer;

namespace Zbw.PF2.ContactManager.Service.Import;

/// <summary>
///     Implements <see cref="IImportService" /> by reading employee records from a CSV file
///     (using the same column layout as <see cref="EmployeeMap" />) and persisting every row
///     that passes the same validation rules used when adding an employee manually.
/// </summary>
public class ImportService : IImportService
{
    private readonly IContactManagerRepository _repository;
    private readonly EmployeeValidatorService _validator;
    private readonly CsvConfiguration _csvConfig;

    /// <summary>
    ///     Initializes a new instance of <see cref="ImportService" /> with the default,
    ///     CSV-backed repository.
    /// </summary>
    public ImportService() : this(new ContactManagerRepository(new CSVRepository()))
    {
    }

    /// <summary>
    ///     Initializes a new instance of <see cref="ImportService" /> with the given repository.
    /// </summary>
    /// <param name="repository">The repository used to persist imported employees.</param>
    public ImportService(IContactManagerRepository repository)
    {
        _repository = repository;
        _validator = new EmployeeValidatorService();
        _csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true };
    }

    /// <summary>
    ///     Counts the data rows (excluding the header) contained in the given CSV file.
    /// </summary>
    /// <param name="filePath">The path to the CSV file to inspect.</param>
    /// <returns>The number of data rows in the file.</returns>
    /// <exception cref="FileNotFoundException">Thrown when <paramref name="filePath" /> does not exist.</exception>
    public int GetTotalAmountOfRecords(string filePath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Die angegebene Importdatei wurde nicht gefunden.", filePath);
        }

        using StreamReader reader = new(filePath);
        using CsvReader csv = new(reader, _csvConfig);

        csv.Read();
        csv.ReadHeader();

        int count = 0;
        while (csv.Read())
        {
            count++;
        }

        return count;
    }

    /// <summary>
    ///     Imports employees from the given CSV file. Every row is parsed and then validated with
    ///     the same <see cref="EmployeeValidatorService" /> rules used for manually added employees;
    ///     rows that fail to parse or fail validation are skipped rather than aborting the import.
    /// </summary>
    /// <param name="filePath">The path to the CSV file to import.</param>
    /// <param name="totalRecords">The total number of data rows found in the file.</param>
    /// <param name="validRecords">The number of rows that were successfully validated and imported.</param>
    /// <param name="invalidRecords">The number of rows that failed parsing or validation and were skipped.</param>
    /// <exception cref="FileNotFoundException">Thrown when <paramref name="filePath" /> does not exist.</exception>
    public bool ImportEmployees(string filePath, out int totalRecords, out int validRecords, out int invalidRecords, ref ProgressBar progressBar)
    {
        bool success = false;

        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Die angegebene Importdatei wurde nicht gefunden.", filePath);
        }

        totalRecords = 0;
        validRecords = 0;
        invalidRecords = 0;

        int nextId = _repository.GetEmployees()
            .Select(employee => employee.Id)
            .DefaultIfEmpty(0)
            .Max();

        using StreamReader reader = new(filePath);
        using CsvReader csv = new(reader, _csvConfig);
        csv.Context.RegisterClassMap<EmployeeMap>();

        csv.Read();
        csv.ReadHeader();

        while (csv.Read())
        {
            totalRecords++;

            Employee employee;
            try
            {
                employee = csv.GetRecord<Employee>() ?? throw new InvalidOperationException("csv.GetRecord<Employee>()");
            }
            catch (Exception)
            {
                invalidRecords++;
                continue;
            }

            EmployeeInput input = ToEmployeeInput(employee);
            ValidationResult validation = _validator.Validate(input);

            if (!validation.IsValid)
            {
                invalidRecords++;
                continue;
            }

            nextId++;
            employee.Id = nextId;

            _repository.AddEmployee(employee);
            validRecords++;
            progressBar.Step++;
        }

        success = true;

        return success;
    }

    /// <summary>
    ///     Converts a parsed <see cref="Employee" /> record into an <see cref="EmployeeInput" /> so it
    ///     can be run through the shared <see cref="EmployeeValidatorService" />.
    /// </summary>
    /// <param name="employee">The employee record read from the CSV file.</param>
    /// <returns>An equivalent <see cref="EmployeeInput" />.</returns>
    private static EmployeeInput ToEmployeeInput(Employee employee)
    {
        const string dateFormat = "dd.MM.yyyy";

        return new EmployeeInput
        {
            Salutation = employee.Salutation,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Birthday = employee.Birthday.ToString(dateFormat, CultureInfo.InvariantCulture),
            Sex = employee.Sex,
            Title = employee.Title,

            PrivateStreetName = employee.Address.StreetName,
            PrivateStreetNumber = employee.Address.StreetNumber,
            PrivateZipCode = employee.Address.ZipCode.ToString(CultureInfo.InvariantCulture),
            PrivateCity = employee.Address.City,

            PhoneNumberCompany = employee.PhoneNumberCompany,
            PhoneNumberMobile = employee.PhoneNumberMobile,
            Email = employee.Email,

            EmployeeNumber = employee.EmployeeNumber,
            Department = employee.Department,
            AhvNumber = employee.AhvNumber,
            Nationality = employee.Nationality,
            EmploymentRate = employee.EmploymentRate,
            Role = employee.Role,
            ApprenticeshipYears = employee.ApprenticeshipYears,
            EmployeeStatus = employee.Status,
            EmployeeSeniorLevel = employee.SeniorLevel,
            DateOfHire = employee.DateOfHire.ToString(dateFormat, CultureInfo.InvariantCulture),
            DateOfTermination = employee.DateOfTermination?.ToString(dateFormat, CultureInfo.InvariantCulture),

            WorkStreetName = employee.WorkAddress.StreetName,
            WorkStreetNumber = employee.WorkAddress.StreetNumber,
            WorkZipCode = employee.WorkAddress.ZipCode.ToString(CultureInfo.InvariantCulture),
            WorkCity = employee.WorkAddress.City,
        };
    }

    public CustomerInput ImportCustomer(string filePath)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Die angegebene Importdatei wurde nicht gefunden.", filePath);
        }

        using StreamReader reader = new(filePath);

        VCard? vCard = SimpleDeserializer.Default.Deserialize(reader).OfType<VCard>().FirstOrDefault();

        if (vCard is null)
        {
            throw new InvalidDataException("Die Datei enthält keine gültigen vCard-Daten.");
        }

        return ToCustomerInput(vCard);
    }

    /// <summary>
    ///     Maps whatever fields the given vCard provides onto a <see cref="CustomerInput" />. Fields
    ///     with no vCard equivalent (salutation, academic title, customer number/type/status) are
    ///     left unset so they can be filled in by hand when the imported customer is reviewed.
    /// </summary>
    /// <param name="vCard">The parsed vCard to convert.</param>
    /// <returns>An equivalent, partially filled <see cref="CustomerInput" />.</returns>
    private static CustomerInput ToCustomerInput(VCard vCard)
    {
        const string dateFormat = "dd.MM.yyyy";

        VCardAddress? address = vCard.Addresses?.FirstOrDefault();
        VCardTelephone? mobilePhone = vCard.Telephones?.FirstOrDefault(phone => phone.Types?.Contains("CELL", StringComparer.OrdinalIgnoreCase) == true);
        VCardTelephone? workPhone = vCard.Telephones?.FirstOrDefault(phone => phone.Types?.Contains("WORK", StringComparer.OrdinalIgnoreCase) == true);
        VCardTelephone? anyPhone = vCard.Telephones?.FirstOrDefault();

        return new CustomerInput
        {
            FirstName = vCard.N?.GivenName ?? string.Empty,
            LastName = vCard.N?.FamilyName ?? string.Empty,
            Birthday = ParseBirthdate(vCard.Birthdate, dateFormat),

            PhoneNumberMobile = mobilePhone?.Value ?? (workPhone is null ? anyPhone?.Value ?? string.Empty : string.Empty),
            PhoneNumberCompany = workPhone?.Value ?? string.Empty,
            Email = vCard.Emails?.FirstOrDefault()?.Value ?? string.Empty,

            StreetName = address?.StreetAddress ?? string.Empty,
            ZipCode = address?.PostalCode ?? string.Empty,
            City = address?.Locality ?? string.Empty,

            CustomerCompanyName = vCard.Organization?.Name ?? string.Empty,
        };
    }

    /// <summary>
    ///     Parses a vCard BDAY value, which is a raw string in one of a few common formats
    ///     depending on the vCard version that produced it, into the app's usual date format.
    ///     Returns <c>null</c> (rather than throwing) when the value is missing or unrecognized,
    ///     so the birthday is simply left blank for manual entry.
    /// </summary>
    private static string? ParseBirthdate(string? rawBirthdate, string dateFormat)
    {
        if (string.IsNullOrWhiteSpace(rawBirthdate))
        {
            return null;
        }

        string[] knownFormats = ["yyyyMMdd", "yyyy-MM-dd", "yyyyMMddTHHmmssZ", "yyyy-MM-ddTHH:mm:ssZ"];

        if (DateTime.TryParseExact(rawBirthdate, knownFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthdate)
            || DateTime.TryParse(rawBirthdate, CultureInfo.InvariantCulture, DateTimeStyles.None, out birthdate))
        {
            return birthdate.ToString(dateFormat, CultureInfo.InvariantCulture);
        }

        return null;
    }
}
