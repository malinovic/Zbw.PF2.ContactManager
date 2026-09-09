using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Represents an employee, in addition to the shared <see cref="Person" /> data.
/// </summary>
public class Employee : Person
{
    /// <summary>
    ///     Gets or sets the employee's unique employee number.
    /// </summary>
    public required string EmployeeNumber { get; set; }

    /// <summary>
    ///     Gets or sets the department the employee works in.
    /// </summary>
    public required string Department { get; set; }

    /// <summary>
    ///     Gets or sets the employee's Swiss social security (AHV) number.
    /// </summary>
    public required string AhvNumber { get; set; }

    /// <summary>
    ///     Gets or sets the employee's nationality.
    /// </summary>
    public required string Nationality { get; set; }

    /// <summary>
    ///     Gets or sets the employee's employment rate, as a percentage (e.g. 100 for full-time).
    /// </summary>
    public required int EmploymentRate { get; set; }

    /// <summary>
    ///     Gets or sets the employee's job role/title.
    /// </summary>
    public required string Role { get; set; }

    /// <summary>
    ///     Gets or sets the total duration of the employee's apprenticeship in years, if applicable.
    /// </summary>
    public int? ApprenticeshipYears { get; set; }

    /// <summary>
    ///     Gets or sets the employee's current apprenticeship year, if applicable.
    /// </summary>
    public int? CurrentApprenticeshipYear { get; set; }

    /// <summary>
    ///     Gets or sets the employee's work address.
    /// </summary>
    public required Address WorkAddress { get; set; }

    /// <summary>
    ///     Gets or sets the employee's current status (active/passive).
    /// </summary>
    public required Status Status { get; set; }

    /// <summary>
    ///     Gets or sets the employee's seniority level.
    /// </summary>
    public required EmployeeSeniorLevel SeniorLevel { get; set; }

    /// <summary>
    ///     Gets or sets the date the employee was hired.
    /// </summary>
    public required DateOnly DateOfHire { get; set; }

    /// <summary>
    ///     Gets or sets the date the employee's employment ended, if applicable.
    /// </summary>
    public DateOnly? DateOfTermination { get; set; }
}