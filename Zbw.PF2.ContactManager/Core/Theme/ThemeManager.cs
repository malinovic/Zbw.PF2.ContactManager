namespace Zbw.PF2.ContactManager.Core.Theme;

internal static class ThemeManager
{
    internal static void ApplyNavLabelStyles(Label label)
    {
        label.Font = new Font(FontManager.InterRegular.FontFamily, 20F, FontStyle.Bold);
        label.ForeColor = Color.Black;
    }

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
        button.BackColor = Color.White;
        button.ForeColor = Color.Black;
        button.FlatAppearance.BorderSize = 0;
        button.Cursor = Cursors.Hand;
    }

    internal static void ApplyNavButtonStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Regular);
        button.BackColor = Color.White;
        button.ForeColor = Color.Black;
        button.FlatAppearance.BorderSize = 0;
        button.Cursor = Cursors.Hand;
    }
}
