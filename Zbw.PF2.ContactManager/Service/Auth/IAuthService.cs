using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Service.Auth;

public interface IAuthService
{
    bool CreateUser(string username, string password, string name);

    /// <summary>
    ///     Authenticates a user. Returns the matching <see cref="User" /> on success, or
    ///     <c>null</c> if the username/password combination is invalid.
    /// </summary>
    User? Login(string username, string password);

    /// <summary>
    ///     Updates an existing user's username and name. If <paramref name="password" /> is
    ///     null or empty, the user's current password is left unchanged; otherwise it is
    ///     hashed and replaces the existing one.
    /// </summary>
    bool UpdateUser(int id, string username, string name, string? password);

    bool HasAdminUser();
}