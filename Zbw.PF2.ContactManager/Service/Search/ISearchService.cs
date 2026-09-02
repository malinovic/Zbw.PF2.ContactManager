using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Service.Search;

/// <summary>
///     Filters employees by a free-text search term and an optional status filter.
/// </summary>
public interface ISearchService
{
    /// <summary>
    ///     Filters the given employees by name, employee number, or department, and optionally by status.
    /// </summary>
    /// <param name="employees">The employees to filter.</param>
    /// <param name="searchTerm">The free-text term to match against first name, last name, employee number, and department.</param>
    /// <param name="statusFilter">The <see cref="Status" /> to restrict results to, or <c>null</c> to include all statuses.</param>
    /// <returns>The employees matching the search term and status filter.</returns>
    public IList<Employee> SearchEmployees(IList<Employee> employees, string searchTerm, object? statusFilter);

}
