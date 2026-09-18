using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Represents an employee, extending <see cref="Person"/> with employment-specific data.
/// </summary>
public class Employee : Person
{
    /// <summary>Gets or sets the employee's unique employee number.</summary>
    public required string EmployeeNumber { get; set; }
    /// <summary>Gets or sets the department the employee works in.</summary>
    public required string Department { get; set; }
    /// <summary>Gets or sets the employee's AHV (social security) number.</summary>
    public required string AhvNumber { get; set; }
    /// <summary>Gets or sets the employee's nationality.</summary>
    public required string Nationality { get; set; }
    /// <summary>Gets or sets the employee's employment rate, in percent.</summary>
    public required int EmploymentRate { get; set; }
    /// <summary>Gets or sets the employee's role.</summary>
    public required string Role { get; set; }
    /// <summary>Gets or sets the total number of years of the employee's apprenticeship, if applicable.</summary>
    public int? ApprenticeshipYears { get; set; }
    /// <summary>Gets or sets the current year of the employee's apprenticeship, if applicable.</summary>
    public int? CurrentApprenticeshipYear { get; set; }
    /// <summary>Gets or sets the employee's work address.</summary>
    public required Address WorkAddress { get; set; }
    /// <summary>Gets or sets the employee's current status.</summary>
    public required Status Status { get; set; }
    /// <summary>Gets or sets the employee's seniority level.</summary>
    public required EmployeeSeniorLevel SeniorLevel { get; set; }
    /// <summary>Gets or sets the date the employee was hired.</summary>
    public required DateOnly DateOfHire { get; set; }
    /// <summary>Gets or sets the date the employee's employment was terminated, if applicable.</summary>
    public DateOnly? DateOfTermination { get; set; }

}
