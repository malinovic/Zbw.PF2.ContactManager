using CsvHelper.Configuration;

using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Maps;

/// <summary>
///     CsvHelper class map for <see cref="User" />.
/// </summary>
public sealed class UserMap : ClassMap<User>
{
    /// <summary>
    ///     Initializes a new instance of <see cref="UserMap" /> and registers all column mappings.
    /// </summary>
    public UserMap()
    {
        Map(m => m.Id).Index(0).Name("id");
        Map(x => x.Name).Index(1).Name("Name");
        Map(x => x.Password).Index(2).Name("Password");
        Map(x => x.Username).Index(3).Name("Username");
    }
}