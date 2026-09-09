using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Validation.ValidationCustomer;

/// <summary>
///     Holds the raw, unvalidated field values entered on the customer create/edit form.
/// </summary>
public sealed class CustomerInput
{
    /// <summary>
    ///     Gets the entered salutation.
    /// </summary>
    public Salutation? Salutation { get; init; }

    /// <summary>
    ///     Gets the entered first name.
    /// </summary>
    public string FirstName { get; init; } = string.Empty;

    /// <summary>
    ///     Gets the entered last name.
    /// </summary>
    public string LastName { get; init; } = string.Empty;

    /// <summary>
    ///     Gets the entered date of birth, as raw text (format "dd.MM.yyyy").
    /// </summary>
    public string? Birthday { get; init; }

    /// <summary>
    ///     Gets the entered sex.
    /// </summary>
    public Sex? Sex { get; init; }

    /// <summary>
    ///     Gets the entered title.
    /// </summary>
    public Title? Title { get; init; }

    /// <summary>
    ///     Gets the entered business phone number.
    /// </summary>
    public string PhoneNumberCompany { get; init; } = string.Empty;

    /// <summary>
    ///     Gets the entered mobile phone number.
    /// </summary>
    public string PhoneNumberMobile { get; init; } = string.Empty;

    /// <summary>
    ///     Gets the entered email address.
    /// </summary>
    public string Email { get; init; } = string.Empty;

    /// <summary>
    ///     Gets the entered street name.
    /// </summary>
    public string StreetName { get; init; } = string.Empty;

    /// <summary>
    ///     Gets the entered street/house number.
    /// </summary>
    public string StreetNumber { get; init; } = string.Empty;

    /// <summary>
    ///     Gets the entered postal (ZIP) code.
    /// </summary>
    public string ZipCode { get; init; } = string.Empty;

    /// <summary>
    ///     Gets the entered city.
    /// </summary>
    public string City { get; init; } = string.Empty;

    /// <summary>
    ///     Gets the customer number (auto-generated when creating a new customer).
    /// </summary>
    public string CustomerNumber { get; init; } = string.Empty;

    /// <summary>
    ///     Gets the selected customer status.
    /// </summary>
    public Status? CustomerStatus { get; init; }
}