

using Zbw.PF2.ContactManager.Core.Constants;


namespace Zbw.PF2.ContactManager.Models;

public class Customer : Person
{
    public required string CustomerNumber { get; set; }
    public required Status CustomerStatus { get; set; }

}
