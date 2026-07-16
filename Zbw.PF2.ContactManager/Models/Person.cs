using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Zbw.PF2.ContactManager.Models.Enums;

namespace Zbw.PF2.ContactManager.Models;

internal class Person
{
    // Properties

    public string Id { get; protected set; }
    public CustomEnums.Salutation Salutation { get; protected set; }
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public DateOnly Birthday { get; protected set; }
    public CustomEnums.Sex Sex { get; protected set; }
    public string Title { get; protected set; }
    public Address Address {  get; protected set; }
    public string PhoneNumberCompany { get; protected set; }
    public string PhoneNumberMobile { get; protected set; }
    public string Email { get; protected set; }


    // Methods

    protected string IsActive(CustomEnums.Status status)
    {
        if (status == CustomEnums.Status.aktiv)
        {
            return "Dieser Mitarbeiter ist aktiv";
        }
        else
        {
            return "Dieser Mitarbeiter ist inaktiv";
        }

    }



    public void SetStatus()
    {
        
    }
}
