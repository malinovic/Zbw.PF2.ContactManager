using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.Auth;

namespace Zbw.PF2.ContactManager.UI;

/// <summary>
///     The application's entry-point login screen. Creates a default admin account on first
///     launch if none exists yet, and opens <see cref="MainForm" /> after a successful login.
/// </summary>
public partial class FormLogin : Form
{
    private readonly IAuthService _authService = new AuthService();

    /// <summary>
    ///     Initializes a new instance of <see cref="FormLogin" />.
    /// </summary>
    public FormLogin()
    {
        InitializeComponent();

        SetupView();

        _checkHasOneUser();
    }

    /// <summary>
    ///     Applies the shared visual theme (fonts, field styles, button styles) to the form.
    /// </summary>
    private void SetupView()
    {
        Font = FontManager.InterRegular;

        ThemeManager.ApplyModernFieldStyles(this);
        ThemeManager.ApplyButtonStyles(btnLogin);
    }

    /// <summary>
    ///     Ensures at least one admin account exists, creating a default "admin"/"admin"
    ///     account on first launch if none does yet.
    /// </summary>
    private void _checkHasOneUser()
    {
        var hasAdminUser = _authService.HasAdminUser();

        if (!hasAdminUser)
        {
            _authService.CreateUser("admin", "admin", "Admin");
        }
    }

    /// <summary>
    ///     Attempts to log in with the entered credentials. On success, opens <see cref="MainForm" />
    ///     and hides the login window; on failure, shows an error and clears the password field.
    /// </summary>
    private void btnLogin_Click(object sender, EventArgs e)
    {
        User? user = _authService.Login(txtUsername.Text, txtPassword.Text);

        if (user is null)
        {
            MessageBox.Show("Ungültiger Benutzername oder Passwort", "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear();
        }
        else
        {
            var mainForm = new MainForm(user);
            mainForm.FormClosed += (s, args) => Close();
            mainForm.Show();
            Hide();
        }
    }
}