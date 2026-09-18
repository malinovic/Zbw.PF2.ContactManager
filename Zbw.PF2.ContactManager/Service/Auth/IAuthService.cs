using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Service.Auth;

/// <summary>
///     Handles user authentication and account management (creation, login, and updates).
/// </summary>
public interface IAuthService
{
    /// <summary>
    ///     Creates a new user with the given credentials and name.
    /// </summary>
    /// <param name="username">The username of the new user.</param>
    /// <param name="password">The plain-text password to hash and store for the new user.</param>
    /// <param name="name">The display name of the new user.</param>
    /// <returns><c>true</c> if the user was created successfully; otherwise, <c>false</c>.</returns>
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

    /// <summary>
    ///     Determines whether at least one admin user already exists.
    /// </summary>
    /// <returns><c>true</c> if an admin user exists; otherwise, <c>false</c>.</returns>
    bool HasAdminUser();
}