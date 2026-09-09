using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.UI.Partials;

namespace Zbw.PF2.ContactManager.UI;

/// <summary>
///     The application's main window: hosts the side navigation and swaps in the active
///     child view (dashboard, customers, employees, or users) in its content panel.
/// </summary>
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

    /// <summary>
    ///     Applies the shared visual theme, hides the "Benutzer" navigation entry for non-admin
    ///     users, and opens the dashboard as the initial view.
    /// </summary>
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
    ///     Hides the "Benutzer" navigation entry. Only called for non-admin users, since managing
    ///     application users is restricted to the admin account.
    /// </summary>
    private void HideUsersNavigationButton()
    {
        BtnNavUsers.Visible = false;
    }

    #region Navigation

    /// <summary>
    ///     Switches the content view to the dashboard.
    /// </summary>
    private void BtnNavDashboard_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormDashboardPartial(_contactManagerRepository));
        SetActiveNavigationButton(BtnNavDashboard);
    }

    /// <summary>
    ///     Switches the content view to the customer list.
    /// </summary>
    private void BtnNavCustomers_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormCustomersPartial(_contactManagerRepository));
        SetActiveNavigationButton(BtnNavCustomers);
    }

    /// <summary>
    ///     Switches the content view to the employee list.
    /// </summary>
    private void BtnNavEmployees_Click(object sender, EventArgs e)
    {
        OpenChildForm(new FormEmployeesPartial(_contactManagerRepository));
        SetActiveNavigationButton(BtnNavEmployees);
    }

    /// <summary>
    ///     Switches the content view to the user management list (admin only).
    /// </summary>
    private void BtnNavUsers_Click(object? sender, EventArgs e)
    {
        OpenChildForm(new FormUsersPartial(_contactManagerRepository, _currentUser));
        SetActiveNavigationButton(BtnNavUsers);
    }

    /// <summary>
    ///     Marks the given navigation button as active and restores the previously active
    ///     button's normal style.
    /// </summary>
    /// <param name="button">The navigation button to mark as active.</param>
    private void SetActiveNavigationButton(Button button)
    {
        if (_activeNavigationButton != null)
        {
            ThemeManager.ApplyNavButtonStyles(_activeNavigationButton);
        }

        _activeNavigationButton = button;
        ThemeManager.ApplyNavButtonActiveStyles(_activeNavigationButton);
    }

    /// <summary>
    ///     Closes the currently displayed child form (if any) and shows the given one embedded
    ///     in the content panel instead.
    /// </summary>
    /// <param name="childForm">The form to display.</param>
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