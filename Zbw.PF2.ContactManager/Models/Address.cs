namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Represents a postal address made up of a street, street number, zip code and city.
/// </summary>
public class Address
{

    /// <summary>Gets or sets the street name of the address.</summary>
    public required string StreetName { get; set; }
    /// <summary>Gets or sets the street number of the address.</summary>
    public required string StreetNumber { get; set; }
    /// <summary>Gets or sets the zip code of the address.</summary>
    public required int ZipCode { get; set; }
    /// <summary>Gets or sets the city of the address.</summary>
    public required string City { get; set; }
    /// <summary>
    ///     Returns a human-readable, single-line representation of the address.
    /// </summary>
    /// <returns>The address formatted as "StreetName StreetNumber, ZipCode City".</returns>
    public override string ToString()
    {
        return $"{StreetName} {StreetNumber}, {ZipCode} {City}";
    }
}
