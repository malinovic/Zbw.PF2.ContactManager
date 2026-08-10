using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Validation.ValidationEmployee;

public sealed class EmployeeInput
{
    public Salutation? Salutation { get; init; }
    public string FirstName { get; init; } = string.Empty;
    public string LastName {  get; init; } = string.Empty;
    public string? Birthday {  get; init; }
    public Sex? Sex { get; init; }
    public Title? Title {  get; init; }
    public string PhoneNumberCompany { get; init; } = string.Empty;
    public string PhoneNumberMobile { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;

    public string PrivateStreetName { get; init; } = string.Empty;
    public string PrivateStreetNumber { get; init; } = string.Empty;
    public string PrivateZipCode { get; init; } = string.Empty;
    public string PrivateCity { get; init; } = string.Empty;

    public string EmployeeNumber { get; init; } = string.Empty;
    public string Department { get; init; } = string.Empty;
    public string AhvNumber { get; init; } = string.Empty;
    public string Nationality { get; init; } = string.Empty;
    public string EmployeeStatusMessage { get; init; } = string.Empty;
    public int EmploymentRate { get; init; }
    public string Role { get; init; } = string.Empty;
    public int? ApprenticeshipYears { get; init; }
    public Status? EmployeeStatus { get; init; }
    public EmployeeSeniorLevel? EmployeeSeniorLevel { get; init; }
    public string? DateOfHire { get; init; } = string.Empty;
    public string? DateOfTermination { get; init; } = string.Empty;
    public string WorkStreetName { get; init; } = string.Empty;
    public string WorkStreetNumber { get; init; } = string.Empty;
    public string WorkZipCode { get; init; } = string.Empty;
    public string WorkCity { get; init; } = string.Empty;

}
