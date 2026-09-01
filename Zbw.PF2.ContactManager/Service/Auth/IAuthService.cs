namespace Zbw.PF2.ContactManager.Service.Auth;

public interface IAuthService
{
    bool CreateUser(string username, string password, string name);
    bool Login(string username, string password);
    bool HasAdminUser();
}