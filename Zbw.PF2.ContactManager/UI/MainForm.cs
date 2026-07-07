using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.UI.Partials;

namespace Zbw.PF2.ContactManager.UI;

public partial class MainForm : Form
{
    private Button _activeNavigationButton;
    private Form _activeForm;

    public MainForm()
    {
        InitializeComponent();

        SetupView();
    }

    private void SetupView()
    {
        Font = FontManager.InterRegular;

        ThemeManager.ApplyNavLabelStyles(NavTitle);

        SetActiveNavigationButton(BtnNavDashboard);
        ThemeManager.ApplyNavButtonStyles(BtnNavEmployees);
        ThemeManager.ApplyNavButtonStyles(BtnNavCustomers);

        OpenChildForm(new FormDashboardPartial());
    }

    private void BtnNavDashboard_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormDashboardPartial());
        SetActiveNavigationButton(BtnNavDashboard);
    }

    private void BtnNavCustomers_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormCustomersPartial());
        SetActiveNavigationButton(BtnNavCustomers);
    }

    private void BtnNavEmployees_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormEmployeesPartial());
        SetActiveNavigationButton(BtnNavEmployees);
    }

    private void SetActiveNavigationButton(Button button)
    {
        if (_activeNavigationButton != null)
        {
            ThemeManager.ApplyNavButtonStyles(_activeNavigationButton);
        }
        _activeNavigationButton = button;
        ThemeManager.ApplyNavButtonActiveStyles(_activeNavigationButton);
    }

    private void OpenChildForm(Form childForm)
    {
        if (_activeForm != null)
        {
            _activeForm.Close();
        }

        _activeForm = childForm;

        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;

        PnlContentView.Controls.Add(childForm);
        PnlContentView.Tag = childForm;

        childForm.BringToFront();
        childForm.Show();
    }
}
