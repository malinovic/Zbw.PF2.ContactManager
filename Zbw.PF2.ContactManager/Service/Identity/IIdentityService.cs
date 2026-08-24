using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Service.Identity;

internal interface IIdentityService
{
    internal string GenerateEmployeeId(IList<Employee> employees);
}