using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Models.Validation;

/// <summary>
///     Raw, unvalidated input data for creating or editing an employee, typically bound from a
///     form before being validated and mapped onto an <see cref="Zbw.PF2.ContactManager.Models.Employee"/>.
/// </summary>
public sealed class EmployeeInput
{
    /// <summary>Gets or initializes the employee's salutation.</summary>
    public Salutation? Salutation { get; init; }
    /// <summary>Gets or initializes the employee's first name.</summary>
    public string FirstName { get; init; } = string.Empty;
    /// <summary>Gets or initializes the employee's last name.</summary>
    public string LastName { get; init; } = string.Empty;
    /// <summary>Gets or initializes the employee's date of birth as raw input text.</summary>
    public string? Birthday { get; init; }
    /// <summary>Gets or initializes the employee's sex.</summary>
    public Sex? Sex { get; init; }
    /// <summary>Gets or initializes the employee's title.</summary>
    public Title? Title { get; init; }
    /// <summary>Gets or initializes the employee's company phone number.</summary>
    public string PhoneNumberCompany { get; init; } = string.Empty;
    /// <summary>Gets or initializes the employee's mobile phone number.</summary>
    public string PhoneNumberMobile { get; init; } = string.Empty;
    /// <summary>Gets or initializes the employee's email address.</summary>
    public string Email { get; init; } = string.Empty;

    /// <summary>Gets or initializes the street name of the employee's private address.</summary>
    public string PrivateStreetName { get; init; } = string.Empty;
    /// <summary>Gets or initializes the street number of the employee's private address.</summary>
    public string PrivateStreetNumber { get; init; } = string.Empty;
    /// <summary>Gets or initializes the zip code of the employee's private address as raw input text.</summary>
    public string PrivateZipCode { get; init; } = string.Empty;
    /// <summary>Gets or initializes the city of the employee's private address.</summary>
    public string PrivateCity { get; init; } = string.Empty;

    /// <summary>Gets or initializes the employee's unique employee number.</summary>
    public string EmployeeNumber { get; init; } = string.Empty;
    /// <summary>Gets or initializes the department the employee works in.</summary>
    public string Department { get; init; } = string.Empty;
    /// <summary>Gets or initializes the employee's AHV (social security) number.</summary>
    public string AhvNumber { get; init; } = string.Empty;
    /// <summary>Gets or initializes the employee's nationality.</summary>
    public string Nationality { get; init; } = string.Empty;
    /// <summary>Gets or initializes the employee's employment rate, in percent.</summary>
    public int EmploymentRate { get; init; }
    /// <summary>Gets or initializes the employee's role.</summary>
    public string Role { get; init; } = string.Empty;
    /// <summary>Gets or initializes the total number of years of the employee's apprenticeship, if applicable.</summary>
    public int? ApprenticeshipYears { get; init; }
    /// <summary>Gets or initializes the current year of the employee's apprenticeship, if applicable.</summary>
    public int? CurrentApprenticeshipYear { get; init; }
    /// <summary>Gets or initializes the employee's current status.</summary>
    public Status? EmployeeStatus { get; init; }
    /// <summary>Gets or initializes the employee's seniority level.</summary>
    public EmployeeSeniorLevel? EmployeeSeniorLevel { get; init; }
    /// <summary>Gets or initializes the date the employee was hired, as raw input text.</summary>
    public string? DateOfHire { get; init; } = string.Empty;
    /// <summary>Gets or initializes the date the employee's employment was terminated, as raw input text.</summary>
    public string? DateOfTermination { get; init; } = string.Empty;
    /// <summary>Gets or initializes the street name of the employee's work address.</summary>
    public string WorkStreetName { get; init; } = string.Empty;
    /// <summary>Gets or initializes the street number of the employee's work address.</summary>
    public string WorkStreetNumber { get; init; } = string.Empty;
    /// <summary>Gets or initializes the zip code of the employee's work address as raw input text.</summary>
    public string WorkZipCode { get; init; } = string.Empty;
    /// <summary>Gets or initializes the city of the employee's work address.</summary>
    public string WorkCity { get; init; } = string.Empty;

}
