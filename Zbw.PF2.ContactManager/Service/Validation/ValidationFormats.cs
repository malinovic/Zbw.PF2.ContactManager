using System.Text.RegularExpressions;

namespace Zbw.PF2.ContactManager.Service.Validation;

internal class ValidationFormats
{
    internal static Regex EmailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
    internal static Regex PhoneRegex = new(@"^(?:\+41|0041|0)\s?(\d{2})\s?(\d{3})\s?(\d{2})\s?(\d{2})$", RegexOptions.Compiled);
}
