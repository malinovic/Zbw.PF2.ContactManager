using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace Zbw.PF2.ContactManager.Models;

internal class Address
{
    // Properties

    public string StreetName { get; private set; }
    public string StreetNumber { get; private set; }
    public int ZipCode { get; private set; }
    public string City { get; private set; }

    public string AddressInString { get; private set; }


    // Methods

    public string AddressToString()
    {
        string AddressString = this.StreetName + " " + this.StreetNumber + ", " + this.ZipCode + " " + this.City;
        AddressInString = AddressString;
        return AddressString;
    }

}
