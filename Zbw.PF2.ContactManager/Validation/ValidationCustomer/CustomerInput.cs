using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Validation.ValidationCustomer;

public sealed class CustomerInput
{
    public Salutation? Salutation { get; init; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName { get; init; } = string.Empty;
    public string? Birthday { get; init; }
    public Sex? Sex { get; init; }
    public Title? Title { get; init; }
    public string PhoneNumberCompany { get; init; } = string.Empty;
    public string PhoneNumberMobile { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;

    public string StreetName { get; init; } = string.Empty;
    public string StreetNumber { get; init; } = string.Empty;
    public string ZipCode { get; init; } = string.Empty;
    public string City { get; init; } = string.Empty;

    public string CustomerNumber { get; init; } = string.Empty;
    public string CustomerCompanyName { get; init; } = string.Empty;
    public Status? CustomerStatus { get; init; }
    public CustomerType? CustomerType { get; init; }
}