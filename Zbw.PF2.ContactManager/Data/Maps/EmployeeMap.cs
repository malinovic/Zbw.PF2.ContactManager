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
        Map(m => m.Id).Index(0).Name("id");
        Map(m => m.Salutation).Index(1).Name("salutation");
        Map(m => m.FirstName).Index(2).Name("first_name");
        Map(m => m.LastName).Index(3).Name("last_name");
        Map(m => m.Birthday).Index(4).Name("birthday").TypeConverter<CsvHelper.TypeConversion.DateOnlyConverter>().TypeConverterOption.Format("dd.MM.yyyy");
        Map(m => m.Sex).Index(5).Name("sex");
        Map(m => m.Title).Index(6).Name("title");
        Map(m => m.Address.StreetName).Index(7).Name("street_name");
        Map(m => m.Address.StreetNumber).Index(8).Name("street_number");
        Map(m => m.Address.ZipCode).Index(9).Name("zip_code");
        Map(m => m.Address.City).Index(10).Name("city");
        Map(m => m.PhoneNumberCompany).Index(11).Name("phone_number_company");
        Map(m => m.PhoneNumberMobile).Index(12).Name("phone_number_mobile");
        Map(m => m.Email).Index(13).Name("email");

        // Employee
        Map(m => m.EmployeeNumber).Index(14).Name("employee_number");
        Map(m => m.Department).Index(15).Name("department");
        Map(m => m.AhvNumber).Index(16).Name("ahv_number");
        Map(m => m.Nationality).Index(17).Name("nationality");
        Map(m => m.EmploymentRate).Index(18).Name("employee_employment_rate");
        Map(m => m.Role).Index(19).Name("role");
        Map(m => m.ApprenticeshipYears).Index(20).Name("employee_apprenticeship_years");
        Map(m => m.WorkAddress.StreetName).Index(21).Name("work_street_name");
        Map(m => m.WorkAddress.StreetNumber).Index(22).Name("work_street_number");
        Map(m => m.WorkAddress.ZipCode).Index(23).Name("work_zip_code");
        Map(m => m.WorkAddress.City).Index(24).Name("work_city");
        Map(m => m.Status).Index(25).Name("employee_status");
        Map(m => m.SeniorLevel).Index(26).Name("employee_senior_level");
        Map(m => m.DateOfHire).Index(27).Name("employee_date_of_hire").TypeConverter<CsvHelper.TypeConversion.DateOnlyConverter>().TypeConverterOption.Format("dd.MM.yyyy");
        // Map(m => m.DateOfTermination).Index(28).Name("employee_date_of_termination").TypeConverter<CsvHelper.TypeConversion.DateTimeConverter>().TypeConverterOption.Format("dd.MM.yyyy");
    }
}
