namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     A single logged contact (e.g. a phone call or note) with a customer, kept as an
///     append-only history entry.
/// </summary>
public class CustomerContact : QueryableEntity
{
    /// <summary>Gets or sets the date and time the contact took place.</summary>
    public required DateTime ContactDate { get; set; }
    /// <summary>Gets or sets the note describing the contact.</summary>
    public required string Note { get; set; }
    /// <summary>Gets or sets the identifier of the customer this contact belongs to.</summary>
    public required int CustomerId { get; set; }
    /// <summary>Gets or sets the identifier of the user who created this contact entry.</summary>
    public required int CreatedByUserId { get; set; }
}
