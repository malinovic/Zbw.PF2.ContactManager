using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.Auth;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormUserDetail : Form
{
    private const string AdminUsername = "admin";

    private readonly IAuthService _authService;
    private readonly IContactManagerRepository _repository;
    private readonly User? _editingUser;

    /// <summary>
    ///     Opens the form for creating a new user.
    /// </summary>
    public FormUserDetail() : this(null)
    {
    }

    /// <summary>
    ///     Opens the form pre-filled for editing an existing user. Passing <c>null</c> keeps
    ///     the original "create new user" behavior.
    /// </summary>
    public FormUserDetail(User? user)
    {
        InitializeComponent();

        _authService = new AuthService();
        _repository = new ContactManagerRepository(new CSVRepository());

        SetupView();

        _editingUser = user;
        if (user is not null)
        {
            PopulateFields(user);
            Text = "Benutzer bearbeiten";
        }
    }

    private void PopulateFields(User user)
    {
        boxUsername.Text = user.Username;
        boxName.Text = user.Name;
        boxPassword.PlaceholderText = "Leer lassen, um das Passwort nicht zu ändern";

        // The admin account's username is locked so it can't accidentally be renamed away
        // from "admin", which would break the admin-only access checks throughout the app.
        if (user.Username == AdminUsername)
        {
            boxUsername.ReadOnly = true;
            boxUsername.BackColor = Color.Gainsboro;
        }
    }

    private void SetupView()
    {
        Font = FontManager.InterRegular;

        ThemeManager.ApplyModernFieldStyles(this);

        ThemeManager.ApplyButtonStyles(buttonSave);
        ThemeManager.ApplyButtonStyles(buttonCancel);
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        string username = boxUsername.Text.Trim();
        string name = boxName.Text.Trim();
        string password = boxPassword.Text;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(name))
        {
            MessageBox.Show("Benutzername und Name dürfen nicht leer sein.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        if (_editingUser is null && string.IsNullOrWhiteSpace(password))
        {
            MessageBox.Show("Bitte ein Passwort vergeben.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        bool usernameTaken = _repository.GetUsers()
            .Any(user => user.Username == username && user.Id != (_editingUser?.Id ?? 0));

        if (usernameTaken)
        {
            MessageBox.Show("Dieser Benutzername ist bereits vergeben.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );

            return;
        }

        bool success = _editingUser is null
            ? _authService.CreateUser(username, password, name)
            : _authService.UpdateUser(_editingUser.Id, username, name, string.IsNullOrEmpty(password) ? null : password);

        if (!success)
        {
            MessageBox.Show("Der Benutzer konnte nicht gespeichert werden.",
                "Fehler",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            return;
        }

        MessageBox.Show(_editingUser is null
            ? "Benutzer wurde erfolgreich erstellt."
            : "Benutzer wurde erfolgreich aktualisiert.");

        Close();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        DialogResult confirmation = MessageBox.Show(
            "Wollen sie wirklich abbrechen? Ungespeicherte Änderungen gehen verloren.",
            "Abbrechen?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        Close();
    }
}
