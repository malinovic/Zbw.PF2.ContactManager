namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Represents a postal address.
/// </summary>
public class Address
{
    /// <summary>
    ///     Gets or sets the street name.
    /// </summary>
    public required string StreetName { get; set; }

    /// <summary>
    ///     Gets or sets the street/house number.
    /// </summary>
    public required string StreetNumber { get; set; }

    /// <summary>
    ///     Gets or sets the postal (ZIP) code.
    /// </summary>
    public required int ZipCode { get; set; }

    /// <summary>
    ///     Gets or sets the city.
    /// </summary>
    public required string City { get; set; }

    /// <summary>
    ///     Returns the address formatted as "Street Number, ZipCode City".
    /// </summary>
    /// <returns>The formatted address string.</returns>
    public override string ToString()
    {
        return $"{StreetName} {StreetNumber}, {ZipCode} {City}";
    }
}