using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace Zbw.PF2.ContactManager.Models;

public class Address
{

    public string StreetName { get; private set; }
    public string StreetNumber { get; private set; }
    public int ZipCode { get; private set; }
    public string City { get; private set; }

    public string AddressInString { get; private set; }


    public string AddressToString()
    {
        string AddressString = this.StreetName + " " + this.StreetNumber + ", " + this.ZipCode + " " + this.City;
        AddressInString = AddressString;
        return AddressString;
    }

}
