namespace Zbw.PF2.ContactManager.Models;

public class Address
{

    public required string StreetName { get; set; }
    public required string StreetNumber { get; set; }
    public required int ZipCode { get; set; }
    public required string City { get; set; }
    public override string ToString()
    {
        return $"{StreetName} {StreetNumber}, {ZipCode} {City}";
    }
}
