namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Represents a login account used to access the application.
/// </summary>
public class User : QueryableEntity
{
    /// <summary>
    ///     Gets or sets the username used to log in.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    ///     Gets or sets the user's password. Stored as provided by the caller.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    ///     Gets or sets the user's display name.
    /// </summary>
    public string Name { get; set; }
}