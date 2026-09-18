namespace Zbw.PF2.ContactManager.Core.Errors;

/// <summary>
///     Represents the possible error states encountered while locating or reading CSV data files.
/// </summary>
public enum CSVErrorStates
{
    /// <summary>The expected data directory does not exist.</summary>
    DIRECTORY_DOES_NOT_EXIST,
    /// <summary>The employees CSV file does not exist.</summary>
    EMPLOYEES_FILE_DOES_NOT_EXIST,
    /// <summary>The customer CSV file does not exist.</summary>
    CUSTOMER_FILE_DOES_NOT_EXIST,
}