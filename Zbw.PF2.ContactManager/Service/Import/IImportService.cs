using Zbw.PF2.ContactManager.Validation.ValidationCustomer;

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

    /// <summary>
    ///     Imports a single customer from the given vCard (.vcf) file, mapping whatever fields
    ///     the vCard provides onto a <see cref="CustomerInput" /> for review before saving. Fields
    ///     with no vCard equivalent (e.g. salutation, customer number) are left unset. Only the
    ///     first contact in the file is used.
    /// </summary>
    /// <param name="filePath">The path to the vCard file to import.</param>
    /// <returns>A <see cref="CustomerInput" /> pre-filled from the vCard's first contact.</returns>
    CustomerInput ImportCustomer(string filePath);
}
