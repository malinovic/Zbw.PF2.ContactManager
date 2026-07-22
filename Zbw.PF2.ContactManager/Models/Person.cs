using Zbw.PF2.ContactManager.Core.Constants;

namespace Zbw.PF2.ContactManager.Models;

public class Person
{

    public int Id { get; set; }
    public Salutation Salutation { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly Birthday { get; set; }
    public Sex Sex { get; set; }
    public Title Title { get; set; }
    public Address Address { get; set; }
    public string PhoneNumberCompany { get; set; }
    public string PhoneNumberMobile { get; set; }
    public string Email { get; set; }

}
