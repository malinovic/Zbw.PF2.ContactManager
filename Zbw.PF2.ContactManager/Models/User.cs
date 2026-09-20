namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Represents an application user account used to log in to the contact manager.
/// </summary>
public class User : QueryableEntity
{
    /// <summary>Gets or sets the user's login username.</summary>
    public string Username { get; set; }
    /// <summary>Gets or sets the user's password.</summary>
    public string Password { get; set; }
    /// <summary>Gets or sets the user's display name.</summary>
    public string Name { get; set; }
}