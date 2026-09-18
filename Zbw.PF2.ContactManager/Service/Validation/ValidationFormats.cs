using System.Text.RegularExpressions;

namespace Zbw.PF2.ContactManager.Service.Validation;

/// <summary>
///     Shared regular expressions used to validate email addresses, phone numbers, and AHV numbers.
/// </summary>
internal class ValidationFormats
{
    internal static Regex EmailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
    internal static Regex PhoneRegex = new(@"^(?:\+41|0041|0)\s?(\d{2})\s?(\d{3})\s?(\d{2})\s?(\d{2})$", RegexOptions.Compiled);

    internal static Regex AHVRegex = new(@"^756\.\d{4}\.\d{4}\.\d{2}$", RegexOptions.Compiled);
}
