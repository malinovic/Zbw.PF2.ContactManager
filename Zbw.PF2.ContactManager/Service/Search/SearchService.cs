using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Service.Search;

public sealed class SearchService : ISearchService
{
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
