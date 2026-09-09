using System.Text.RegularExpressions;

namespace Zbw.PF2.ContactManager.Service.Validation;

/// <summary>
///     Provides shared regular expressions for validating common input formats.
/// </summary>
internal class ValidationFormats
{
    /// <summary>
    ///     Matches a basic "local@domain.tld" email address format.
    /// </summary>
    internal static Regex EmailRegex = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

    /// <summary>
    ///     Matches a Swiss phone number, optionally prefixed with "+41", "0041", or "0".
    /// </summary>
    internal static Regex PhoneRegex = new(@"^(?:\+41|0041|0)\s?(\d{2})\s?(\d{3})\s?(\d{2})\s?(\d{2})$", RegexOptions.Compiled);

    /// <summary>
    ///     Matches a Swiss AHV (social security) number in the format "756.XXXX.XXXX.XX".
    /// </summary>
    internal static Regex AHVRegex = new(@"^756\.\d{4}\.\d{4}\.\d{2}$", RegexOptions.Compiled);
}