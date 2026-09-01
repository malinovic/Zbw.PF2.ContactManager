using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.PasswordHash;

namespace Zbw.PF2.ContactManager.Service.Auth;

internal class AuthService : IAuthService
{
    private readonly IContactManagerRepository _repository = new ContactManagerRepository(new CSVRepository());
    private readonly IPasswordHashService _passwordHashService = new PasswordHashService();

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

    public User? Login(string username, string password)
    {
        bool isAuthenticated = _repository.CheckLoginForUser(username, password);

        if (!isAuthenticated)
        {
            return null;
        }

        return _repository.GetUsers().FirstOrDefault(user => user.Username == username);
    }

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

    public bool HasAdminUser()
    {
        return _repository.HasAdminUser();
    }
}