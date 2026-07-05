namespace Zbw.PF2.ContactManager.Core.Theme;

internal static class ThemeManager
{
    internal static void ApplyButtonStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Font = new Font("Arial", 11F);
        button.BackColor = Color.White;
    }
}
