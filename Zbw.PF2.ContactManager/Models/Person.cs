using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Represents the data shared by both customers and employees.
/// </summary>
public class Person : QueryableEntity
{
    /// <summary>
    ///     Gets or sets the person's salutation.
    /// </summary>
    public Salutation Salutation { get; set; }

    /// <summary>
    ///     Gets or sets the person's first name.
    /// </summary>
    public required string FirstName { get; set; }

    /// <summary>
    ///     Gets or sets the person's last name.
    /// </summary>
    public required string LastName { get; set; }

    /// <summary>
    ///     Gets or sets the person's date of birth.
    /// </summary>
    public required DateOnly Birthday { get; set; }

    /// <summary>
    ///     Gets or sets the person's sex.
    /// </summary>
    public required Sex Sex { get; set; }

    /// <summary>
    ///     Gets or sets the person's title.
    /// </summary>
    public required Title Title { get; set; }

    /// <summary>
    ///     Gets or sets the person's address.
    /// </summary>
    public required Address Address { get; set; }

    /// <summary>
    ///     Gets or sets the person's business phone number.
    /// </summary>
    public required string PhoneNumberCompany { get; set; }

    /// <summary>
    ///     Gets or sets the person's mobile phone number.
    /// </summary>
    public required string PhoneNumberMobile { get; set; }

    /// <summary>
    ///     Gets or sets the person's email address.
    /// </summary>
    public required string Email { get; set; }
}