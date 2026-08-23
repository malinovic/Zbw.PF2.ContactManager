using CsvHelper.Configuration;

using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Maps;

/// <summary>
///     CsvHelper class map for <see cref="Customer" />.
///     Defines the mapping between CSV column names and all properties inherited from
///     <see cref="Person" /> as well as the customer-specific properties.
/// </summary>
public class CustomerMap : ClassMap<Customer>
{
    /// <summary>
    ///     Initializes a new instance of <see cref="CustomerMap" /> and registers all column mappings.
    /// </summary>
    public CustomerMap()
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

        // Customer
        Map(m => m.CustomerNumber).Index(14).Name("customer_number");
        Map(m => m.CustomerCompanyName).Index(15).Name("customer_company_name");
        Map(m => m.CustomerStatus).Index(16).Name("customer_status");
        Map(m => m.CustomerType).Index(17).Name("customer_type");
    }
}
