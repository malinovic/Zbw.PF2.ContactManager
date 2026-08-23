namespace Zbw.PF2.ContactManager.Core.Constants;

/// <summary>
///     German display text for the enums used in the employee combo boxes. The enum
///     names themselves stay in English since they are used for CSV persistence.
/// </summary>
public static class EnumDisplayExtensions
{
    public static string ToGerman(this Salutation salutation) => salutation switch
    {
        Salutation.Mr => "Herr",
        Salutation.Mrs => "Frau",
        _ => salutation.ToString()
    };

    public static string ToGerman(this Sex sex) => sex switch
    {
        Sex.Male => "Männlich",
        Sex.Female => "Weiblich",
        _ => sex.ToString()
    };

    public static string ToGerman(this Title title) => title switch
    {
        Title.None => "Kein Titel",
        Title.Dr => "Dr.",
        Title.Prof => "Prof.",
        Title.ProfDr => "Prof. Dr.",
        _ => title.ToString()
    };

    public static string ToGerman(this Status status) => status switch
    {
        Status.Active => "Aktiv",
        Status.Passive => "Passiv",
        _ => status.ToString()
    };
}
