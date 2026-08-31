namespace Zbw.PF2.ContactManager.Service.Import;

public interface IImportService
{
    /// <summary>
    ///     Counts the data rows (excluding the header) contained in the given CSV file.
    /// </summary>
    /// <param name="filePath">The path to the CSV file to inspect.</param>
    /// <returns>The number of data rows in the file.</returns>
    int GetTotalAmountOfRecords(string filePath);

    /// <summary>
    ///     Imports employees from the given CSV file, validating every row with the same rules
    ///     used when adding an employee manually, and persists every valid row.
    /// </summary>
    /// <param name="filePath">The path to the CSV file to import.</param>
    /// <param name="totalRecords">The total number of data rows found in the file.</param>
    /// <param name="validRecords">The number of rows that were successfully validated and imported.</param>
    /// <param name="invalidRecords">The number of rows that failed parsing or validation and were skipped.</param>
    /// <param name="recordsProcessed">The number of rows that have been processed.</param>
    bool ImportEmployees(string filePath, out int totalRecords, out int validRecords, out int invalidRecords, ref ProgressBar progressBar);
}
