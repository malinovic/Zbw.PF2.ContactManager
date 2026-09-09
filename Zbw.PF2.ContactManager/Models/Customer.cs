using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Represents a customer, in addition to the shared <see cref="Person" /> data.
/// </summary>
public class Customer : Person
{
    /// <summary>
    ///     Gets or sets the customer's unique customer number.
    /// </summary>
    public required string CustomerNumber { get; set; }

    /// <summary>
    ///     Gets or sets the customer's current status (active/passive).
    /// </summary>
    public required Status CustomerStatus { get; set; }
}