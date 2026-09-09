namespace Zbw.PF2.ContactManager.Models;

/// <summary>
///     Base type for entities that are stored and looked up by a unique identifier.
/// </summary>
public class QueryableEntity
{
    /// <summary>
    ///     Gets or sets the entity's unique identifier.
    /// </summary>
    public int Id { get; set; }
}