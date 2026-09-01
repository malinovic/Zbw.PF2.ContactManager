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

    /// <summary>
    ///     Generates the next customer number, based on the highest existing customer number.
    /// </summary>
    /// <param name="customers">The existing customers to derive the next number from.</param>
    /// <returns>A new, unique customer number.</returns>
    internal string GenerateCustomerId(IList<Models.Customer> customers);
}