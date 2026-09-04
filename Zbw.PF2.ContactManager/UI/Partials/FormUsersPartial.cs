using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormUsersPartial : Form
{
    private const string AdminUsername = "admin";

    private readonly IContactManagerRepository _repository;

    /// <summary>
    ///     Initializes a new instance of <see cref="FormUsersPartial" /> and loads the user list.
    ///     Only reachable by the admin account (gated in <see cref="MainForm" />).
    /// </summary>
    /// <param name="contactManagerRepository">The repository used to load and persist users.</param>
    /// <param name="currentUser">The currently logged-in user.</param>
    public FormUsersPartial(IContactManagerRepository contactManagerRepository, User currentUser)
    {
        InitializeComponent();

        _repository = contactManagerRepository;

        ThemeManager.ApplyDataGridViewStyles(dgvUsers);

        ConfigureGridColumns();
        ConfigureRowContextMenu();

        dgvUsers.CellDoubleClick += DgvUsers_CellDoubleClick;

        RefreshUsers();
    }

    private void BtnCreateNewUser_Click(object sender, EventArgs e)
    {
        using var form = new FormUserDetail();
        form.ShowDialog(this);

        RefreshUsers();
    }

    private void DgvUsers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvUsers.Rows[e.RowIndex].DataBoundItem is not User user)
        {
            return;
        }

        EditUser(user);
    }

    /// <summary>
    ///     Builds the grid's columns, deliberately excluding the password column so hashed
    ///     passwords are never displayed.
    /// </summary>
    private void ConfigureGridColumns()
    {
        dgvUsers.AutoGenerateColumns = false;
        dgvUsers.Columns.Clear();
        dgvUsers.Columns.AddRange(
            CreateColumn("Username", "Benutzername", 200),
            CreateColumn("Name", "Name", 260));

        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    /// <summary>
    ///     Wires up a right-click context menu (edit / delete) on grid rows. "Löschen" is
    ///     disabled for the admin account so the app can never end up without an admin user.
    /// </summary>
    private void ConfigureRowContextMenu()
    {
        var menuEdit = new ToolStripMenuItem("Bearbeiten");
        menuEdit.Click += (_, _) => EditSelectedUser();

        var menuDelete = new ToolStripMenuItem("Löschen");
        menuDelete.Click += (_, _) => DeleteSelectedUser();

        var contextMenu = new ContextMenuStrip();
        contextMenu.Items.Add(menuEdit);
        contextMenu.Items.Add(menuDelete);

        contextMenu.Opening += (_, e) =>
        {
            User? user = GetSelectedUser();
            if (user is null)
            {
                e.Cancel = true;
                return;
            }

            menuDelete.Enabled = user.Username != AdminUsername;
        };

        dgvUsers.CellMouseDown += (_, e) =>
        {
            if (e.RowIndex < 0 || e.Button != MouseButtons.Right)
            {
                return;
            }

            dgvUsers.ClearSelection();
            dgvUsers.Rows[e.RowIndex].Selected = true;
        };

        dgvUsers.MouseDown += (_, e) =>
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            DataGridView.HitTestInfo hit = dgvUsers.HitTest(e.X, e.Y);
            if (hit.RowIndex < 0)
            {
                return;
            }

            contextMenu.Show(dgvUsers, e.Location);
        };
    }

    private User? GetSelectedUser()
    {
        return dgvUsers.CurrentRow?.DataBoundItem as User;
    }

    private void EditSelectedUser()
    {
        User? user = GetSelectedUser();
        if (user is null)
        {
            return;
        }

        EditUser(user);
    }

    private void EditUser(User user)
    {
        using var form = new FormUserDetail(user);
        form.ShowDialog(this);

        RefreshUsers();
    }

    private void DeleteSelectedUser()
    {
        User? user = GetSelectedUser();
        if (user is null || user.Username == AdminUsername)
        {
            return;
        }

        DialogResult confirmation = MessageBox.Show(
            $"Soll der Benutzer {user.Username} wirklich gelöscht werden?",
            "Benutzer löschen",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        _repository.DeleteUser(user.Id);

        RefreshUsers();
    }

    private static DataGridViewTextBoxColumn CreateColumn(string dataPropertyName, string headerText, int width)
    {
        return new DataGridViewTextBoxColumn
        {
            DataPropertyName = dataPropertyName,
            HeaderText = headerText,
            Name = "column" + dataPropertyName,
            ReadOnly = true,
            FillWeight = width
        };
    }

    private void RefreshUsers()
    {
        usersBindingSource.DataSource = _repository.GetUsers();
    }
}
