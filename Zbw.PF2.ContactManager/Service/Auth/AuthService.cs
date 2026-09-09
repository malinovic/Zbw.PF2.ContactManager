using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.PasswordHash;

namespace Zbw.PF2.ContactManager.Service.Auth;

/// <summary>
///     Implements <see cref="IAuthService" /> by delegating storage to <see cref="IContactManagerRepository" />
///     and hashing passwords via <see cref="IPasswordHashService" />.
/// </summary>
internal class AuthService : IAuthService
{
    private readonly IContactManagerRepository _repository = new ContactManagerRepository(new CSVRepository());
    private readonly IPasswordHashService _passwordHashService = new PasswordHashService();

    /// <summary>
    ///     Creates a new user account with a hashed password.
    /// </summary>
    /// <param name="username">The username for the new account.</param>
    /// <param name="password">The plain-text password for the new account.</param>
    /// <param name="name">The display name of the new user.</param>
    /// <returns><c>true</c> if the account was created successfully; otherwise, <c>false</c>.</returns>
    public bool CreateUser(string username, string password, string name)
    {
        var hashedPassword = _passwordHashService.Hash(password);

        try
        {
            _repository.CreateUser(username, hashedPassword, name);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }

        return true;
    }

    /// <summary>
    ///     Authenticates a user. Returns the matching <see cref="User" /> on success, or
    ///     <c>null</c> if the username/password combination is invalid.
    /// </summary>
    /// <param name="username">The username to authenticate.</param>
    /// <param name="password">The plain-text password to verify.</param>
    public User? Login(string username, string password)
    {
        bool isAuthenticated = _repository.CheckLoginForUser(username, password);

        if (!isAuthenticated)
        {
            return null;
        }

        return _repository.GetUsers().FirstOrDefault(user => user.Username == username);
    }

    /// <summary>
    ///     Updates an existing user's username and name. If <paramref name="password" /> is
    ///     null or empty, the user's current password is left unchanged; otherwise it is
    ///     hashed and replaces the existing one.
    /// </summary>
    /// <param name="id">The id of the user to update.</param>
    /// <param name="username">The new username.</param>
    /// <param name="name">The new display name.</param>
    /// <param name="password">The new plain-text password, or <c>null</c>/empty to keep the current one.</param>
    /// <returns><c>true</c> if the update succeeded; <c>false</c> if the user was not found or the update failed.</returns>
    public bool UpdateUser(int id, string username, string name, string? password)
    {
        User? existing = _repository.GetUser(id);
        if (existing is null)
        {
            return false;
        }

        string hashedPassword = string.IsNullOrEmpty(password)
            ? existing.Password
            : _passwordHashService.Hash(password);

        try
        {
            _repository.UpdateUser(new User
            {
                Id = id,
                Username = username,
                Name = name,
                Password = hashedPassword
            });
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return false;
        }

        return true;
    }

    /// <summary>
    ///     Checks whether at least one admin user already exists.
    /// </summary>
    /// <returns><c>true</c> if an admin user exists; otherwise, <c>false</c>.</returns>
    public bool HasAdminUser()
    {
        return _repository.HasAdminUser();
    }
}