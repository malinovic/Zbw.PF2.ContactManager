using System.Collections;
using System.Security.Cryptography;

namespace Zbw.PF2.ContactManager.Service.PasswordHash;

internal class PasswordHashService : IPasswordHashService
{
    private const int _saltSize = 16;
    private const int _keySize = 32;
    private const int _iterations = 210_000;
    private static readonly HashAlgorithmName _hashAlgo = HashAlgorithmName.SHA256;

    public string Hash(string password)
    {
        byte[]? salt = RandomNumberGenerator.GetBytes(_saltSize);
        byte[]? hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, _iterations, _hashAlgo, _keySize);

        return string.Join(';', "PBKDF2", _hashAlgo.Name, Convert.ToBase64String(salt), Convert.ToBase64String(hash));
    }

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
