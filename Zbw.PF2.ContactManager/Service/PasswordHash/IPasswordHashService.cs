namespace Zbw.PF2.ContactManager.Service.PasswordHash;

/// <summary>
///     Hashes and verifies user passwords.
/// </summary>
public interface IPasswordHashService
{
    /// <summary>
    ///     Hashes the given plain-text password.
    /// </summary>
    /// <param name="password">The plain-text password to hash.</param>
    /// <returns>A string encoding the algorithm, salt, and derived hash.</returns>
    string Hash(string password);

    /// <summary>
    ///     Verifies that the given plain-text password matches a previously hashed password.
    /// </summary>
    /// <param name="password">The plain-text password to check.</param>
    /// <param name="hashedPassword">The previously hashed password, as produced by <see cref="Hash" />.</param>
    /// <returns><c>true</c> if the password matches; otherwise, <c>false</c>.</returns>
    bool Verify(string password, string hashedPassword);
}
