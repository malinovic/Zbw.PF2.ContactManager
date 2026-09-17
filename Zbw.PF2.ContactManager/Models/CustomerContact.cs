namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     A single logged contact (e.g. a phone call or note) with a customer, kept as an
///     append-only history entry.
/// </summary>
public class CustomerContact : QueryableEntity
{
    public required DateTime ContactDate { get; set; }
    public required string Note { get; set; }
    public required int CustomerId { get; set; }
    public required int CreatedByUserId { get; set; }
}
