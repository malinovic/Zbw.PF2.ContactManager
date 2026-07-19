using System;
using System.Collections.Generic;
using System.Security.Cryptography.Pkcs;
using System.Text;

namespace Zbw.PF2.ContactManager.Models;

public class Address
{

    public string StreetName { get; set; }
    public string StreetNumber { get; set; }
    public int ZipCode { get; set; }
    public string City { get;  set; }
    public string AddressInString
    {
        get
        {
            return $"{StreetName} {StreetNumber}, {ZipCode} {City} ";
        }
    }

}
