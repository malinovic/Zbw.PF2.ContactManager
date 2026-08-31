using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Models;

public class Employee : Person
{
    public required string EmployeeNumber { get; set; }
    public required string Department { get; set; }
    public required string AhvNumber { get; set; }
    public required string Nationality { get; set; }
    public required int EmploymentRate { get; set; }
    public required string Role { get; set; }
    public int? ApprenticeshipYears { get; set; }
    public required Address WorkAddress { get; set; }
    public required Status Status { get; set; }
    public required EmployeeSeniorLevel SeniorLevel { get; set; }
    public required DateOnly DateOfHire { get; set; }
    public DateOnly? DateOfTermination { get; set; }

}
