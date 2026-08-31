using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Service.Identity;

/// <summary>
///     Generates unique, human-readable employee identifiers.
/// </summary>
internal interface IIdentityService
{
    /// <summary>
    ///     Generates the next employee number, based on the highest existing employee number.
    /// </summary>
    /// <param name="employees">The existing employees to derive the next number from.</param>
    /// <returns>A new, unique employee number.</returns>
    internal string GenerateEmployeeId(IList<Employee> employees);
}