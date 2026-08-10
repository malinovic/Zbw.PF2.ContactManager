using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Models;

public class Employee : Person
{
    public required string EmployeeNumber { get; set; }
    public required string Department { get; set; }
    public required string AhvNumber { get; set; }
    public required string Nationality { get; set; }
    public required int EmployeeEmploymentRate { get; set; }
    public required string Role { get; set; }
    public int? EmployeeApprenticeshipYears { get; set; }
    public required Address WorkAddress { get; set; }
    public required Status EmployeeStatus { get; set; }
    public required EmployeeSeniorLevel EmployeeSeniorLevel { get; set; }
    public required string EmployeeDateOfHire { get; set; }
    public string? EmployeeDateOfTermination { get; set; }

}
