using CsvHelper.Configuration;

using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Maps;

public class CustomerMap : ClassMap<Customer>
{
    public CustomerMap()
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

        // Customer
        Map(m => m.CustomerNumber).Name("customer_number");
        Map(m => m.CustomerCompanyName).Name("customer_company_name");
        Map(m => m.CustomerStatus).Name("customer_status");
        Map(m => m.CustomerType).Name("customer_type");
    }
}
