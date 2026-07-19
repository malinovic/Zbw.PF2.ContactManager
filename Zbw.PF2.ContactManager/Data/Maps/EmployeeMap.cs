using CsvHelper.Configuration;

using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Maps;

/// <summary>
///     CsvHelper class map for <see cref="Employee" />.
///     Defines the mapping between CSV column names and all properties inherited from
///     <see cref="Person" /> as well as the employee-specific properties, including
///     both the personal <see cref="Person.Address" /> and the <see cref="Employee.WorkAddress" />.
/// </summary>
public class EmployeeMap : ClassMap<Employee>
{
    /// <summary>
    ///     Initializes a new instance of <see cref="EmployeeMap" /> and registers all column mappings.
    /// </summary>
    public EmployeeMap()
    {
        // Person
        Map(m => m.Id).Name("id");
        Map(m => m.Salutation).Name("salutation");
        Map(m => m.FirstName).Name("first_name");
        Map(m => m.LastName).Name("last_name");
        Map(m => m.Birthday).Name("birthday");
        Map(m => m.Sex).Name("sex");
        Map(m => m.Title).Name("title");
        Map(m => m.Address.StreetName).Name("street_name");
        Map(m => m.Address.StreetNumber).Name("street_number");
        Map(m => m.Address.ZipCode).Name("zip_code");
        Map(m => m.Address.City).Name("city");
        Map(m => m.PhoneNumberCompany).Name("phone_number_company");
        Map(m => m.PhoneNumberMobile).Name("phone_number_mobile");
        Map(m => m.Email).Name("email");

        // Employee
        Map(m => m.EmployeeNumber).Name("employee_number");
        Map(m => m.Department).Name("department");
        Map(m => m.AhvNumber).Name("ahv_number");
        Map(m => m.Nationality).Name("nationality");
        Map(m => m.EmployeeStatusMessage).Name("employee_status_message");
        Map(m => m.EmployeeEmploymentRate).Name("employee_employment_rate");
        Map(m => m.Role).Name("role");
        Map(m => m.EmployeeApprenticeshipYears).Name("employee_apprenticeship_years");
        Map(m => m.WorkAddress.StreetName).Name("work_street_name");
        Map(m => m.WorkAddress.StreetNumber).Name("work_street_number");
        Map(m => m.WorkAddress.ZipCode).Name("work_zip_code");
        Map(m => m.WorkAddress.City).Name("work_city");
        Map(m => m.EmployeeStatus).Name("employee_status");
        Map(m => m.EmployeeSeniorLevel).Name("employee_senior_level");
        Map(m => m.EmployeeDateOfHire).Name("employee_date_of_hire");
    }
}
