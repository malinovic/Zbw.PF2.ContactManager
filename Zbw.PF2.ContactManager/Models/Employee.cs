using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Models;

public class Employee : Person
{
    public string EmployeeNumber { get; set; }
    public string Department { get; set; }
    public string AhvNumber { get; set; }
    public string Nationality { get; set; }
    public string EmployeeStatusMessage { get; set; }
    public int EmployeeEmploymentRate { get; set; }
    public string Role { get; set; }
    public int EmployeeApprenticeshipYears { get; set; }
    public Address WorkAddress { get; set; }
    public Status EmployeeStatus { get; set; }
    public EmployeeSeniorLevel EmployeeSeniorLevel { get; set; }
    public DateOnly EmployeeDateOfHire { get; set; }

}
