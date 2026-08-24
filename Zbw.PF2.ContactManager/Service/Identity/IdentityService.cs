using System.Text.RegularExpressions;

using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Service.Identity;

public class IdentityService : IIdentityService
{
    private const string Prefix = "MA-";
    private static readonly Regex EmployeeNumberRegex = new(@"^MA-(\d+)$", RegexOptions.Compiled);

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
}