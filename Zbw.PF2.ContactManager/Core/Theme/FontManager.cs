using System;
using System.Collections.Generic;
using System.Text;

namespace Zbw.PF2.ContactManager.Core.Theme;

using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

public static class FontManager
{
    private static PrivateFontCollection _fontCollection = new PrivateFontCollection();

    public static Font InterRegular { get; private set; }

    /// <summary>
    /// Initializes the custom fonts by loading them from the specified font files.
    /// </summary>
    public static void InitializeFonts()
    {
        string regularPath = Path.Combine(Application.StartupPath, "Inter.ttf");

        if (File.Exists(regularPath)) _fontCollection.AddFontFile(regularPath);

        if (_fontCollection.Families.Length > 0)
        {
            foreach (var family in _fontCollection.Families)
            {
                if (family.Name.Equals("Inter", StringComparison.OrdinalIgnoreCase))
                {
                    InterRegular = new Font(family, 11f, FontStyle.Regular);
                    return;
                }
            }
        }

        InterRegular = new Font("Segoe UI", 11f, FontStyle.Regular);
    }
}
