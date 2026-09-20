using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Validation.ValidationCustomer;

/// <summary>
///     Raw, unvalidated input data for creating or editing a customer, typically bound from a
///     form before being validated and mapped onto a <see cref="Zbw.PF2.ContactManager.Models.Customer"/>.
/// </summary>
public sealed class CustomerInput
{
    /// <summary>Gets or initializes the customer's salutation.</summary>
    public Salutation? Salutation { get; init; }
    /// <summary>Gets or initializes the customer's first name.</summary>
    public string FirstName { get; init; } = string.Empty;
    /// <summary>Gets or initializes the customer's last name.</summary>
    public string LastName { get; init; } = string.Empty;
    /// <summary>Gets or initializes the customer's date of birth as raw input text.</summary>
    public string? Birthday { get; init; }
    /// <summary>Gets or initializes the customer's sex.</summary>
    public Sex? Sex { get; init; }
    /// <summary>Gets or initializes the customer's title.</summary>
    public Title? Title { get; init; }
    /// <summary>Gets or initializes the customer's company phone number.</summary>
    public string PhoneNumberCompany { get; init; } = string.Empty;
    /// <summary>Gets or initializes the customer's mobile phone number.</summary>
    public string PhoneNumberMobile { get; init; } = string.Empty;
    /// <summary>Gets or initializes the customer's email address.</summary>
    public string Email { get; init; } = string.Empty;

    /// <summary>Gets or initializes the street name of the customer's address.</summary>
    public string StreetName { get; init; } = string.Empty;
    /// <summary>Gets or initializes the street number of the customer's address.</summary>
    public string StreetNumber { get; init; } = string.Empty;
    /// <summary>Gets or initializes the zip code of the customer's address as raw input text.</summary>
    public string ZipCode { get; init; } = string.Empty;
    /// <summary>Gets or initializes the city of the customer's address.</summary>
    public string City { get; init; } = string.Empty;

    /// <summary>Gets or initializes the customer's unique customer number.</summary>
    public string CustomerNumber { get; init; } = string.Empty;
    /// <summary>Gets or initializes the customer's current status.</summary>
    public Status? CustomerStatus { get; init; }
}