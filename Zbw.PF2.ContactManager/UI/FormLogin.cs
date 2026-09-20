using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.Auth;

namespace Zbw.PF2.ContactManager.UI;

/// <summary>
///     Login form shown at application startup. Authenticates the user against stored
///     credentials and opens <see cref="MainForm" /> on successful login.
/// </summary>
public partial class FormLogin : Form
{
    private readonly IAuthService _authService = new AuthService();

    /// <summary>
    ///     Initializes a new instance of <see cref="FormLogin" />, applies the modern field
    ///     styles and ensures a default admin user exists before the form is shown.
    /// </summary>
    public FormLogin()
    {
        InitializeComponent();

        SetupView();

        _checkHasOneUser();
    }

    private void SetupView()
    {
        Font = FontManager.InterRegular;

        ThemeManager.ApplyModernFieldStyles(this);
        ThemeManager.ApplyButtonStyles(btnLogin);
    }

    private void _checkHasOneUser()
    {
        var hasAdminUser = _authService.HasAdminUser();

        if (!hasAdminUser)
        {
            _authService.CreateUser("admin", "admin", "Admin");
        }
    }

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