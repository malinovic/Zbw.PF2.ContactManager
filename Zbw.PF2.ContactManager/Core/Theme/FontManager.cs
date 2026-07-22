namespace Zbw.PF2.ContactManager.Core.Theme;

using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

public static class FontManager
{
    private static readonly PrivateFontCollection FontCollection = new();

    /// <summary>
    /// Gets the Inter Regular font. If the Inter font is not available, it falls back to Segoe UI.
    /// </summary>
    public static Font InterRegular { get; private set; } = new Font("Segoe UI", 11f, FontStyle.Regular);

    /// <summary>
    /// Initializes the custom fonts by loading them from the specified font files.
    /// </summary>
    public static void InitializeFonts()
    {
        string regularPath = Path.Combine(Application.StartupPath, "Inter.ttf");

        if (File.Exists(regularPath)) FontCollection.AddFontFile(regularPath);

        if (FontCollection.Families.Length > 0)
        {
            foreach (var family in FontCollection.Families)
            {
                if (family.Name.Equals("Inter", StringComparison.OrdinalIgnoreCase))
                {
                    InterRegular = new Font(family, 11f, FontStyle.Regular);
                    return;
                }
            }
        }
    }
}
