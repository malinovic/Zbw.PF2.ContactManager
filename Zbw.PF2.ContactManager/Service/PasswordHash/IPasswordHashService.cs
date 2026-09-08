namespace Zbw.PF2.ContactManager.Service.PasswordHash;

public interface IPasswordHashService
{
    string Hash(string password);
    bool Verify(string password, string hashedPassword);
}
