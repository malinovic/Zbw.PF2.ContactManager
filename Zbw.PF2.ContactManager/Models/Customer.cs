

using Zbw.PF2.ContactManager.Core.Constants;


namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Represents a customer, extending <see cref="Person"/> with customer-specific data.
/// </summary>
public class Customer : Person
{
    /// <summary>Gets or sets the customer's unique customer number.</summary>
    public required string CustomerNumber { get; set; }
    /// <summary>Gets or sets the customer's current status.</summary>
    public required Status CustomerStatus { get; set; }

}
