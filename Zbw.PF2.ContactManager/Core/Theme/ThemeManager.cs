namespace Zbw.PF2.ContactManager.Core.Theme;

internal static class ThemeManager
{
    internal static void ApplyButtonStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font("Arial", 11F);
        button.BackColor = Color.White;
    }

    internal static void ApplyNavButtonActiveStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Bold);
        button.BackColor = Color.FromArgb(193, 117, 43);
        button.ForeColor = Color.White;
    }

    internal static void ApplyNavButtonStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Bold);
        button.BackColor = Color.White;
        button.ForeColor = Color.Black;
    }
}
