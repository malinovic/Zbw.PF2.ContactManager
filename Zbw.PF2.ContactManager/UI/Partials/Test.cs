using Zbw.PF2.ContactManager.Core.Theme;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class Test : Form
{
    public Test()
    {
        InitializeComponent();

        ThemeManager.ApplyButtonStyles(button1);
    }
}
