using CsvHelper.Configuration;

using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Maps;

/// <summary>
///     CsvHelper class map for <see cref="CustomerContact" />.
/// </summary>
public class CustomerContactMap : ClassMap<CustomerContact>
{
    /// <summary>
    ///     Initializes a new instance of <see cref="CustomerContactMap" /> and registers all column mappings.
    /// </summary>
    public CustomerContactMap()
    {
        Map(m => m.Id).Index(0).Name("id");
        Map(m => m.CustomerId).Index(1).Name("customer_id");
        Map(m => m.ContactDate).Index(2).Name("contact_date").TypeConverter<CsvHelper.TypeConversion.DateTimeConverter>().TypeConverterOption.Format("dd.MM.yyyy HH:mm:ss");
        Map(m => m.Note).Index(3).Name("note");
        Map(m => m.CreatedByUserId).Index(4).Name("created_by_user_id");
    }
}
