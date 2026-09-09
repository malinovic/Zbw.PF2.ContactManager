namespace Zbw.PF2.ContactManager.Service.PasswordHash;

/// <summary>
///     Hashes and verifies passwords for secure storage.
/// </summary>
public interface IPasswordHashService
{
    /// <summary>
    ///     Hashes the given plain-text password using a randomly generated salt.
    /// </summary>
    /// <param name="password">The plain-text password to hash.</param>
    /// <returns>A string encoding the algorithm, salt, and hash, suitable for storage.</returns>
    string Hash(string password);

    /// <summary>
    ///     Verifies whether the given plain-text password matches a previously hashed password.
    /// </summary>
    /// <param name="password">The plain-text password to verify.</param>
    /// <param name="hashedPassword">The previously hashed password to compare against.</param>
    /// <returns><c>true</c> if the password matches; otherwise, <c>false</c>.</returns>
    bool Verify(string password, string hashedPassword);
}