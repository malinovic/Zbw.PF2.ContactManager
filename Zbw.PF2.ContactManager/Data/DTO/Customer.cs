using CsvHelper.Configuration.Attributes;

namespace Zbw.PF2.ContactManager.Data.DTO;

public class Customer : Person
{
    [Name("name")] [Index(1)] public string Name { get; set; }
}