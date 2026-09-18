namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Base class for entities that can be queried and persisted, providing a common identifier.
/// </summary>
public class QueryableEntity
{
    /// <summary>Gets or sets the unique identifier of the entity.</summary>
    public int Id { get; set; }
}