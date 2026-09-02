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



    ///////////////////////
    ///

    private const string PrefixCustomer = "CU-";
    private static readonly Regex CustomerNumberRegex = new(@"^CU-(\d+)$", RegexOptions.Compiled);

    /// <summary>
    ///     Generates the next Customer number, based on the highest existing Customer number.
    /// </summary>
    /// <param name="Customers">The existing Customers to derive the next number from.</param>
    /// <returns>A new, unique Customer number in the format "MA-0001".</returns>
    public string GenerateCustomerId(IList<Customer> Customers)
    {
        int highest = Customers
            .Select(Customer => CustomerNumberRegex.Match(Customer.CustomerNumber))
            .Where(match => match.Success)
            .Select(match => int.Parse(match.Groups[1].Value))
            .DefaultIfEmpty(0)
            .Max();

        _getLastCustomerId = highest + 1;

        return $"{Prefix}{_getLastCustomerId:D4}";
    }

    private int _getLastCustomerId;
}