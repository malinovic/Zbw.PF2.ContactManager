namespace Zbw.PF2.ContactManager.Core.Constants;

/// <summary>
///     German display text for the enums used in the employee combo boxes. The enum
///     names themselves stay in English since they are used for CSV persistence.
/// </summary>
public static class EnumDisplayExtensions
{
    /// <summary>
    ///     Returns the German display text for the given <see cref="Salutation" />.
    /// </summary>
    /// <param name="salutation">The salutation to translate.</param>
    /// <returns>The German display text, or the enum's <see cref="object.ToString" /> if unmapped.</returns>
    public static string ToGerman(this Salutation salutation) => salutation switch
    {
        Salutation.Mr => "Herr",
        Salutation.Mrs => "Frau",
        _ => salutation.ToString()
    };

    /// <summary>
    ///     Returns the German display text for the given <see cref="Sex" />.
    /// </summary>
    /// <param name="sex">The sex to translate.</param>
    /// <returns>The German display text, or the enum's <see cref="object.ToString" /> if unmapped.</returns>
    public static string ToGerman(this Sex sex) => sex switch
    {
        Sex.Male => "Männlich",
        Sex.Female => "Weiblich",
        _ => sex.ToString()
    };

    /// <summary>
    ///     Returns the German display text for the given <see cref="Title" />.
    /// </summary>
    /// <param name="title">The title to translate.</param>
    /// <returns>The German display text, or the enum's <see cref="object.ToString" /> if unmapped.</returns>
    public static string ToGerman(this Title title) => title switch
    {
        Title.None => "Kein Titel",
        Title.Dr => "Dr.",
        Title.Prof => "Prof.",
        Title.ProfDr => "Prof. Dr.",
        _ => title.ToString()
    };

    /// <summary>
    ///     Returns the German display text for the given <see cref="Status" />.
    /// </summary>
    /// <param name="status">The status to translate.</param>
    /// <returns>The German display text, or the enum's <see cref="object.ToString" /> if unmapped.</returns>
    public static string ToGerman(this Status status) => status switch
    {
        Status.Active => "Aktiv",
        Status.Passive => "Passiv",
        _ => status.ToString()
    };
}
