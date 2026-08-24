using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Service.Search;

public interface ISearchService
{
    public IList<Employee> SearchEmployees(IList<Employee> employees, string searchTerm, object? statusFilter);
}
