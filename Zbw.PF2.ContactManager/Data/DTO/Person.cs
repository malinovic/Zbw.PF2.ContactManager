using CsvHelper.Configuration.Attributes;

namespace Zbw.PF2.ContactManager.Data.DTO;

public class Person
{
    [Index(0)] [Name("id")] public int Id { get; set; }
}