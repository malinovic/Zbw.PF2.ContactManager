using CsvHelper.Configuration.Attributes;

namespace Zbw.PF2.ContactManager.Data.DTO;

public class Employee : Person
{
    [Name("employee_id")] public string EmployeeNumber { get; set; }
}