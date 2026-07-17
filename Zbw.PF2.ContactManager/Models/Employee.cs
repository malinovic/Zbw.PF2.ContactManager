using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;


namespace Zbw.PF2.ContactManager.Models;

public class Employee : Person

{

    public string EmployeeNumber {  get; set; }
    public string Department { get; set; }
    public string AhvNumber { get; set; }
    public string Nationality { get; set; } 
    public enum EmployeeStatus;
    public string EmployeeStatusMessage { get; set; }
    public DateOnly EmployeeDateOfHire { get; set; }
    public int EmployeeEmploymentRate { get; set; }
    public string Role { get; set; }
    public enum EmployeeSeniorLevel;

    public int EmployeeApprenticeshipYears { get; set; }
    public Address WorkAddress { get; set; }

}
