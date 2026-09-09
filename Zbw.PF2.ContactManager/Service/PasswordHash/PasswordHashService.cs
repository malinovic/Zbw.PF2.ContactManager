using System.Collections;
using System.Security.Cryptography;

namespace Zbw.PF2.ContactManager.Service.PasswordHash;

/// <summary>
///     Implements <see cref="IPasswordHashService" /> using PBKDF2 with a per-password random salt.
/// </summary>
internal class PasswordHashService : IPasswordHashService
{
    private const int _saltSize = 16;
    private const int _keySize = 32;
    private const int _iterations = 210_000;
    private static readonly HashAlgorithmName _hashAlgo = HashAlgorithmName.SHA256;

    /// <summary>
    ///     Hashes the given plain-text password using a randomly generated salt.
    /// </summary>
    /// <param name="password">The plain-text password to hash.</param>
    /// <returns>A string in the format "PBKDF2;{algorithm};{salt};{hash}", suitable for storage.</returns>
    public string Hash(string password)
    {
        byte[]? salt = RandomNumberGenerator.GetBytes(_saltSize);
        byte[]? hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, _iterations, _hashAlgo, _keySize);

        return string.Join(';', "PBKDF2", _hashAlgo.Name, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
    }

    /// <summary>
    ///     Verifies whether the given plain-text password matches a previously hashed password.
    /// </summary>
    /// <param name="password">The plain-text password to verify.</param>
    /// <param name="hashedPassword">The previously hashed password, as produced by <see cref="Hash" />.</param>
    /// <returns><c>true</c> if the password matches; otherwise, <c>false</c>.</returns>
    public bool Verify(string password, string hashedPassword)
    {
        var parts = hashedPassword.Split(';');
        if (parts.Length != 4 || parts[0] != "PBKDF2")
        {
            return false;
        }

        var hashAlgoName = parts[1];
        var salt = Convert.FromBase64String(parts[2]);
        var hash = Convert.FromBase64String(parts[3]);

        if (hashAlgoName != _hashAlgo.Name)
        {
            return false;
        }

        var computedHash = Rfc2898DeriveBytes.Pbkdf2(password, salt, _iterations, _hashAlgo, _keySize);
        return StructuralComparisons.StructuralEqualityComparer.Equals(hash, computedHash);
    }
}