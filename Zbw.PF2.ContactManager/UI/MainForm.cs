using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.UI.Partials;

namespace Zbw.PF2.ContactManager.UI;

public partial class MainForm : Form
{
    private const string AdminUsername = "admin";

    private readonly IContactManagerRepository _contactManagerRepository = new ContactManagerRepository(new CSVRepository());
    private readonly User _currentUser;
    private Form? _activeForm;
    private Button? _activeNavigationButton;

    /// <summary>
    ///     Initializes a new instance of <see cref="MainForm" /> for the given logged-in user and
    ///     shows the dashboard view.
    /// </summary>
    /// <param name="currentUser">The user who successfully logged in.</param>
    public MainForm(User currentUser)
    {
        InitializeComponent();

        _currentUser = currentUser;

        SetupView();
    }

    private void SetupView()
    {
        Font = FontManager.InterRegular;

        SetActiveNavigationButton(BtnNavDashboard);
        ThemeManager.ApplyNavButtonStyles(BtnNavEmployees);
        ThemeManager.ApplyNavButtonStyles(BtnNavCustomers);
        ThemeManager.ApplyNavButtonStyles(BtnNavUsers);
        ThemeManager.ApplyLabelStyles(LblLoggedInAs);

        if (_currentUser.Username != AdminUsername)
        {
            HideUsersNavigationButton();
        }

        LblLoggedInAs.Text = $"Angemeldet als: {_currentUser.Name}";

        OpenChildForm(new FormDashboardPartial(_contactManagerRepository));
    }

    /// <summary>
    ///     Adds the "Benutzer" navigation entry. Only called for the admin user, since managing
    ///     application users is restricted to that account.
    /// </summary>
    private void HideUsersNavigationButton()
    {
        BtnNavUsers.Visible = false;
    }

    #region Navigation

    private void BtnNavDashboard_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormDashboardPartial(_contactManagerRepository));
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

    private void BtnNavUsers_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new FormUsersPartial(_contactManagerRepository, _currentUser));
        SetActiveNavigationButton(BtnNavUsers);
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