using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Zbw.PF2.ContactManager.Models;

public class Person
{

    public string Id { get; set; }
    public enum Salutation;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly Birthday { get; set; }
    public enum Sex;
    public string Title { get; set; }
    public Address Address {  get; set; }
    public string PhoneNumberCompany { get; set; }
    public string PhoneNumberMobile { get; set; }
    public string Email { get; set; }

}
