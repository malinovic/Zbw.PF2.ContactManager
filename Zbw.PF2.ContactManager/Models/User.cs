namespace Zbw.PF2.ContactManager.Models;

public class User : QueryableEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
}