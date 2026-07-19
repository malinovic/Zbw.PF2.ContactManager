using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Repository;

/// <summary>
///     The base repository interface for handling CSV data operations in the Contact Manager application.
/// </summary>
public interface ICSVRepository
{
    IList<T> GetRecords<T>() where T : Person;
    T? GetRecord<T>(int id) where T : Person;

    void CreateRecord<T>(T person) where T : Person;

    void UpdateRecord<T>(T person) where T : Person;
}