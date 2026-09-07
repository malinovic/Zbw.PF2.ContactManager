using System.Text.RegularExpressions;

using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Service.Identity;

/// <summary>
///     Implements <see cref="IIdentityService" /> by generating sequential employee numbers
///     in the format "MA-0001".
/// </summary>
public class IdentityService : IIdentityService
{
    private const string Prefix = "MA-";
    private static readonly Regex EmployeeNumberRegex = new(@"^MA-(\d+)$", RegexOptions.Compiled);

    /// <summary>
    ///     Generates the next employee number, based on the highest existing employee number.
    /// </summary>
    /// <param name="employees">The existing employees to derive the next number from.</param>
    /// <returns>A new, unique employee number in the format "MA-0001".</returns>
    public string GenerateEmployeeId(IList<Employee> employees)
    {
        int highest = employees
            .Select(employee => EmployeeNumberRegex.Match(employee.EmployeeNumber))
            .Where(match => match.Success)
            .Select(match => int.Parse(match.Groups[1].Value))
            .DefaultIfEmpty(0)
            .Max();

        _getLastEmployeeId = highest + 1;

        return $"{Prefix}{_getLastEmployeeId:D4}";
    }

    private int _getLastEmployeeId;

    private const string CustomerPrefix = "KD-";
    private static readonly Regex CustomerNumberRegex = new(@"^KD-(\d+)$", RegexOptions.Compiled);
    private int _getLastCustomerId;

    /// <summary>
    ///     Generates the next customer number, based on the highest existing customer number.
    /// </summary>
    /// <param name="customers">The existing customers to derive the next number from.</param>
    /// <returns>A new, unique customer number in the format "KD-0001".</returns>
    public string GenerateCustomerId(IList<Customer> customers)
    {
        int highest = customers
            .Select(customer => CustomerNumberRegex.Match(customer.CustomerNumber))
            .Where(match => match.Success)
            .Select(match => int.Parse(match.Groups[1].Value))
            .DefaultIfEmpty(0)
            .Max();

        _getLastCustomerId = highest + 1;

        return $"{CustomerPrefix}{_getLastCustomerId:D4}";
    }
}