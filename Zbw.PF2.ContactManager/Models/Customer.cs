

using Zbw.PF2.ContactManager.Core.Constants;


namespace Zbw.PF2.ContactManager.Models;

public class Customer : Person
{

    public string CustomerNumber { get; set; }
    public string CustomerCompanyName { get; set; }
    public Status CustomerStatus { get; set; }
    public CustomerType CustomerType { get; set; }

}
