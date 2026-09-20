using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.Auth;

namespace Zbw.PF2.ContactManager.UI.Partials;

/// <summary>
///     Dialog for creating a new user or editing an existing one, including validation of
///     username uniqueness and required fields.
/// </summary>
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

    /// <summary>
    ///     Fills the form's fields from an existing user and locks the username field when
    ///     editing the admin account.
    /// </summary>
    /// <param name="user">The user whose data is used to populate the form.</param>
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

    /// <summary>
    ///     Applies the shared font, field, and button styling to the form's controls.
    /// </summary>
    private void SetupView()
    {
        Font = FontManager.InterRegular;

        ThemeManager.ApplyModernFieldStyles(this);

        ThemeManager.ApplyButtonStyles(buttonSave);
        ThemeManager.ApplyButtonStyles(buttonCancel);
    }

    /// <summary>
    ///     Validates the entered data and creates or updates the user via <see cref="_authService" />,
    ///     showing validation/error/success feedback and closing the form on success.
    /// </summary>
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

    /// <summary>
    ///     Prompts for confirmation and, if confirmed, closes the form discarding any changes.
    /// </summary>
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
