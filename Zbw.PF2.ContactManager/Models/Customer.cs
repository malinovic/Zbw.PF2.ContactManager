using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace Zbw.PF2.ContactManager.Models;

public class Customer : Person
{

    public string CustomerNumber { get; set; }
    public enum CustomerType;
    public string CustomerCompanyName { get; set; }
    public enum CustomerStatus;
    public string CustomerStatusMessage { get; set; }

}
