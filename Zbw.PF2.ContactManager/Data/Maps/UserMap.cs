using CsvHelper.Configuration;

using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Maps;

/// <summary>
///     Defines how <see cref="User" /> properties map to CSV columns for reading and writing.
/// </summary>
public sealed class UserMap : ClassMap<User>
{
    /// <summary>
    ///     Initializes a new instance of <see cref="UserMap" /> and configures the column mappings.
    /// </summary>
    public UserMap()
    {
        Map(m => m.Id).Index(0).Name("id");
        Map(x => x.Name).Index(1).Name("Name");
        Map(x => x.Password).Index(2).Name("Password");
        Map(x => x.Username).Index(3).Name("Username");
    }
}