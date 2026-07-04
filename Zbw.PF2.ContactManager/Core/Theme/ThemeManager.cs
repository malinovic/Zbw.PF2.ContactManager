namespace Zbw.PF2.ContactManager.Core.Theme;

internal static class ThemeManager
{
    internal static void ApplyButtonStyles(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.Size = new Size(200, 60);
        button.Font = new Font("Arial", 11F);
    }
}
