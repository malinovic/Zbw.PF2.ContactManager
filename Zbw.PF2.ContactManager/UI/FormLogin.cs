using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Service.Auth;

namespace Zbw.PF2.ContactManager.UI;

public partial class FormLogin : Form
{
    private readonly IAuthService _authService = new AuthService();

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
        bool isAuthenticated = _authService.Login(txtUsername.Text, txtPassword.Text);

        if (!isAuthenticated)
        {
            MessageBox.Show("Ungültiger Benutzername oder Passwort", "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear();
        }
        else
        {
            var mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => Close();
            mainForm.Show();
            Hide();
        }
    }
}