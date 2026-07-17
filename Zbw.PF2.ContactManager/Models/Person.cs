using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Zbw.PF2.ContactManager.Models.Enums;

namespace Zbw.PF2.ContactManager.Models;

public class Person
{

    public string Id { get; protected set; }
    public EnumSalutation.Salutation Salutation { get; protected set; }
    public string FirstName { get; protected set; }
    public string LastName { get; protected set; }
    public DateOnly Birthday { get; protected set; }
    public EnumSex.Sex Sex { get; protected set; }
    public string Title { get; protected set; }
    public Address Address {  get; protected set; }
    public string PhoneNumberCompany { get; protected set; }
    public string PhoneNumberMobile { get; protected set; }
    public string Email { get; protected set; }



    protected string IsActive(EnumStatus.Status status)
    {
        if (status == EnumStatus.Status.Active)
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
