using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.UI.Partials;

namespace Zbw.PF2.ContactManager.UI;

public partial class MainForm : Form
{
    private readonly IContactManagerRepository _contactManagerRepository = new ContactManagerRepository(new CSVRepository());
    private Form? _activeForm;
    private Button? _activeNavigationButton;

    public MainForm()
    {
        InitializeComponent();

        SetupView();
    }

    private void SetupView()
    {
        Font = FontManager.InterRegular;

        SetActiveNavigationButton(BtnNavDashboard);
        ThemeManager.ApplyNavButtonStyles(BtnNavEmployees);
        ThemeManager.ApplyNavButtonStyles(BtnNavCustomers);

        OpenChildForm(new FormDashboardPartial());
    }

    #region Navigation

    private void BtnNavDashboard_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormDashboardPartial());
        SetActiveNavigationButton(BtnNavDashboard);
    }

    private void BtnNavCustomers_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormCustomersPartial(_contactManagerRepository));
        SetActiveNavigationButton(BtnNavCustomers);
    }

    private void BtnNavEmployees_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormEmployeesPartial(_contactManagerRepository));
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

        ThemeManager.ApplyFormStyles(childForm);

        PnlContentView.Controls.Add(childForm);
        PnlContentView.Tag = childForm;

        childForm.BringToFront();
        childForm.Show();
    }

    #endregion
}