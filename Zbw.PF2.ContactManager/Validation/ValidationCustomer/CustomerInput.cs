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

    public string PrivateStreetName { get; init; } = string.Empty;
    public string PrivateStreetNumber { get; init; } = string.Empty;
    public string PrivateZipCode { get; init; } = string.Empty;
    public string PrivateCity { get; init; } = string.Empty;

    public string CustomerNumber { get; init; } = string.Empty;

    public Status? CustomerStatus { get; init; }
    public string CustomerCompanyName {  get; init; } = string.Empty;
    public  CustomerType CustomerType {  get; init; }


}
