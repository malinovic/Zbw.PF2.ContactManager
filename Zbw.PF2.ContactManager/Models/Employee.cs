using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Zbw.PF2.ContactManager.Models.Enums;


namespace Zbw.PF2.ContactManager.Models;

internal class Employee : Person

{
    // Properties

    public string EmployeeNumber {  get; private set; }
    public string Department { get; private set; }
    public string AhvNumber { get; private set; }
    public string Nationality { get; private set; } 
    public CustomEnums.Status EmployeeStatus { get; private set; }
    protected string EmployeeStatusMessage => IsActive(EmployeeStatus);
    public DateOnly EmployeeDateOfHire { get; private set; }
    public int EmployeeEmploymentRate { get; private set; }
    public string Role { get; private set; }
    public CustomEnums.EmployeeSeniorLevel EmployeeSeniorLevel {  get; private set; }

    public int EmployeeApprenticeshipYears { get; private set; }
    public Address WorkAddress { get; private set; }




    // Methods

    public string EmployeeToString()
    {
        
        string EmployeeToString = this.FirstName + ", " + this.LastName;
        return EmployeeToString;
    }




    // Constructor

    public Employee(
        string id,
        CustomEnums.Salutation salutation,
        string firstName,
        string lastName,
        DateOnly birthday,
        CustomEnums.Sex sex,
        string title,
        Address address,
        string phoneNumberCompany,
        string phoneNumberMobile,
        string email,
        string employeeNumber,
        string department,
        string ahvNumber,
        string nationality,
        CustomEnums.Status employeeStatus,
        string employeeDateOfHire,
        string employeeEmploymentRate,
        string role,
        CustomEnums.EmployeeSeniorLevel employeeSeniorLevel,
        int employeeApprenticeShipYears,
        Address workAddress
        )
    {
        Id = id;
        Salutation = salutation;
        FirstName = firstName;
        LastName = lastName;
        Birthday = birthday;
        Sex = sex;
        Title = title;
        Address = address;
        PhoneNumberCompany = phoneNumberCompany;
        PhoneNumberMobile = phoneNumberMobile;
        Email = email;
        EmployeeNumber = employeeNumber;
        Department = department;
        AhvNumber = ahvNumber;
        Nationality = nationality;
        EmployeeStatus = employeeStatus;
        Role = role;
        EmployeeSeniorLevel = employeeSeniorLevel;
        EmployeeApprenticeshipYears = employeeApprenticeShipYears;
        WorkAddress = workAddress;
    }
}
