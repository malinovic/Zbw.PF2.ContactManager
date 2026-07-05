using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Zbw.PF2.ContactManager.Core.Theme;

namespace Zbw.PF2.ContactManager.UI;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();

        Font = FontManager.InterRegular;

        BtnNavKunden.Font = new Font(FontManager.InterRegular.FontFamily, 12F, FontStyle.Bold);

        //ThemeManager.ApplyButtonStyles(BtnTest);
    }
}
