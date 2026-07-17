using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Zbw.PF2.ContactManager.Models.Enums;


namespace Zbw.PF2.ContactManager.Models;

public class Employee : Person

{

    public string EmployeeNumber {  get; private set; }
    public string Department { get; private set; }
    public string AhvNumber { get; private set; }
    public string Nationality { get; private set; } 
    public EnumStatus.Status EmployeeStatus { get; private set; }
    protected string EmployeeStatusMessage => IsActive(EmployeeStatus);
    public DateOnly EmployeeDateOfHire { get; private set; }
    public int EmployeeEmploymentRate { get; private set; }
    public string Role { get; private set; }
    public EnumEmployeeSeniorLevel.EmployeeSeniorLevel EmployeeSeniorLevel {  get; private set; }

    public int EmployeeApprenticeshipYears { get; private set; }
    public Address WorkAddress { get; private set; }





    public string EmployeeToString()
    {
        
        string EmployeeToString = this.FirstName + ", " + this.LastName;
        return EmployeeToString;
    }




    public Employee(
        string id,
        EnumSalutation.Salutation salutation,
        string firstName,
        string lastName,
        DateOnly birthday,
        EnumSex.Sex sex,
        string title,
        Address address,
        string phoneNumberCompany,
        string phoneNumberMobile,
        string email,
        string employeeNumber,
        string department,
        string ahvNumber,
        string nationality,
        EnumStatus.Status employeeStatus,
        string employeeDateOfHire,
        string employeeEmploymentRate,
        string role,
        EnumEmployeeSeniorLevel.EmployeeSeniorLevel employeeSeniorLevel,
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
