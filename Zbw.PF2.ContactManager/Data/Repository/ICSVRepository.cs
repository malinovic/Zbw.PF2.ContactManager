using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Repository;

/// <summary>
///     The base repository interface for handling CSV data operations in the Contact Manager application.
/// </summary>
public interface ICSVRepository
{
    /// <summary>
    ///     Retrieves all records of the specified type from the corresponding CSV file.
    /// </summary>
    /// <typeparam name="T">The person-derived type whose CSV file should be read.</typeparam>
    /// <returns>A list containing all records of type <typeparamref name="T" />.</returns>
    IList<T> GetRecords<T>() where T : Person;

    /// <summary>
    ///     Retrieves a single record by its unique identifier.
    /// </summary>
    /// <typeparam name="T">The person-derived type to look up.</typeparam>
    /// <param name="id">The unique identifier of the record to find.</param>
    /// <returns>The matching record, or <c>null</c> if no record with that id exists.</returns>
    T? GetRecord<T>(int id) where T : Person;

    /// <summary>
    ///     Appends a new record to the corresponding CSV file.
    /// </summary>
    /// <typeparam name="T">The person-derived type to persist.</typeparam>
    /// <param name="person">The record to write.</param>
    void CreateRecord<T>(T person) where T : Person;

    /// <summary>
    ///     Replaces an existing record in the CSV file with the provided updated values,
    ///     matched by <see cref="Person.Id" />.
    /// </summary>
    /// <typeparam name="T">The person-derived type to update.</typeparam>
    /// <param name="person">The record containing the updated values.</param>
    void UpdateRecord<T>(T person) where T : Person;

    /// <summary>
    ///     Removes the record with the given identifier from the corresponding CSV file.
    /// </summary>
    /// <typeparam name="T">The person-derived type whose record should be deleted.</typeparam>
    /// <param name="id">The unique identifier of the record to remove.</param>
    void DeleteRecord<T>(int id) where T : Person;
}
