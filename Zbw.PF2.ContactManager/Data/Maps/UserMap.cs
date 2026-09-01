using CsvHelper.Configuration;

using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Maps;

public sealed class UserMap : ClassMap<User>
{
    public UserMap()
    {
        Map(m => m.Id).Index(0).Name("id");
        Map(x => x.Name).Index(1).Name("Name");
        Map(x => x.Password).Index(2).Name("Password");
        Map(x => x.Username).Index(3).Name("Username");
    }
}