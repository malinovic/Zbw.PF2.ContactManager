using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Service.Search;

/// <summary>
///     Implements <see cref="ISearchService" /> using case-insensitive substring matching.
/// </summary>
public sealed class SearchService : ISearchService
{
    /// <summary>
    ///     Filters the given employees by name, employee number, or department, and optionally by status.
    /// </summary>
    /// <param name="employees">The employees to filter.</param>
    /// <param name="searchTerm">The free-text term to match against first name, last name, employee number, and department.</param>
    /// <param name="statusFilter">The <see cref="Status" /> to restrict results to, or <c>null</c> to include all statuses.</param>
    /// <returns>The employees matching the search term and status filter.</returns>
    public IList<Employee> SearchEmployees(IList<Employee> employees, string searchTerm, object? statusFilter)
    {
        IEnumerable<Employee> filtered = employees;

        string search = searchTerm.Trim();
        if (!string.IsNullOrEmpty(search))
        {
            filtered = filtered.Where(employee =>
                employee.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                employee.LastName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                employee.EmployeeNumber.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                employee.Department.Contains(search, StringComparison.OrdinalIgnoreCase));
        }

        if (statusFilter is Status status)
        {
            filtered = filtered.Where(employee => employee.Status == status);
        }

        return [.. filtered];
    }
}
