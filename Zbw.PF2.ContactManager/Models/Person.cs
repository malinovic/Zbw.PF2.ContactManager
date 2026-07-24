using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Models;

public class Person
{

    public int Id { get; set; }
    public Salutation Salutation { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required DateOnly Birthday { get; set; }
    public required Sex Sex { get; set; }
    public required Title Title { get; set; }
    public required Address Address { get; set; }
    public required string PhoneNumberCompany { get; set; }
    public required string PhoneNumberMobile { get; set; }
    public required string Email { get; set; }

}
