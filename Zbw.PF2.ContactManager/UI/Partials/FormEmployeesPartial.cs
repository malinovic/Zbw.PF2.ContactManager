using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.Search;

namespace Zbw.PF2.ContactManager.UI.Partials;

/// <summary>
///     Displays the list of employees in a filterable, sortable grid and provides actions
///     for creating, editing, importing, activating/deactivating, and deleting employees.
/// </summary>
public partial class FormEmployeesPartial : Form
{
    private readonly IContactManagerRepository _repository;
    private readonly ISearchService _searchService = new SearchService();
    private IList<Employee> _employees = [];

    /// <summary>
    ///     Initializes a new instance of <see cref="FormEmployeesPartial" /> and loads the employee list.
    /// </summary>
    /// <param name="contactManagerRepository">The repository used to load and persist employees.</param>
    public FormEmployeesPartial(IContactManagerRepository contactManagerRepository)
    {
        InitializeComponent();

        _repository = contactManagerRepository;

        ThemeManager.ApplyButtonStyles(btnImportEmployees);
        ThemeManager.ApplyDataGridViewStyles(dgvEmployees);

        ConfigureGridColumns();
        ConfigureRowContextMenu();

        dgvEmployees.CellDoubleClick += DataGridView1_CellDoubleClick;

        cmbStatusFilter.Items.Add("Alle");
        foreach (Status status in Enum.GetValues<Status>())
        {
            cmbStatusFilter.Items.Add(status);
        }
        cmbStatusFilter.SelectedIndex = 0;

        _loadEmployees();
    }

    /// <summary>
    ///     Builds the grid's columns from just the fields most useful for scanning the employee
    ///     list at a glance; double-clicking a row opens <see cref="FormEmployeeDetailPartial" /> for the
    ///     full set of details and editing. Defined in code (rather than the Designer file) so it
    ///     survives the WinForms designer regenerating <c>InitializeComponent</c>.
    /// </summary>
    private void ConfigureGridColumns()
    {
        dgvEmployees.AutoGenerateColumns = false;
        dgvEmployees.Columns.Clear();
        dgvEmployees.Columns.AddRange(
            CreateColumn("FirstName", "Vorname", 150),
            CreateColumn("LastName", "Nachname", 150),
            CreateColumn("EmployeeNumber", "Mitarbeiternr.", 140),
            CreateColumn("Department", "Abteilung", 150),
            CreateColumn("Role", "Rolle", 140),
            CreateColumn("Email", "E-Mail", 220),
            CreateColumn("Status", "Status", 120),
            CreateColumn("DateOfHire", "Eingestellt am", 150));

        // Stretch the columns to always fill the grid's full width instead of leaving empty
        // space on wide windows; the basic widths above become the relative fill proportions.
        dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    /// <summary>
    ///     Wires up a right-click context menu (edit / delete) on grid rows. Defined in code
    ///     alongside <see cref="ConfigureGridColumns" /> so it survives designer regeneration.
    /// </summary>
    private void ConfigureRowContextMenu()
    {
        var menuEdit = new ToolStripMenuItem("Bearbeiten");
        menuEdit.Click += (_, _) => EditSelectedEmployee();

        var menuToggleStatus = new ToolStripMenuItem();
        menuToggleStatus.Click += (_, _) => ToggleSelectedEmployeeStatus();

        var menuDelete = new ToolStripMenuItem("Löschen");
        menuDelete.Click += (_, _) => DeleteSelectedEmployee();

        var contextMenu = new ContextMenuStrip();
        contextMenu.Items.Add(menuEdit);
        contextMenu.Items.Add(menuToggleStatus);
        contextMenu.Items.Add(menuDelete);

        contextMenu.Opening += (_, e) =>
        {
            Employee? employee = GetSelectedEmployee();
            if (employee is null)
            {
                e.Cancel = true;
                return;
            }

            menuToggleStatus.Text = employee.Status == Status.Active
                ? "Deaktivieren"
                : "Aktivieren";
        };

        dgvEmployees.CellMouseDown += (_, e) =>
        {
            if (e.RowIndex < 0 || e.Button != MouseButtons.Right)
            {
                return;
            }

            dgvEmployees.ClearSelection();
            dgvEmployees.Rows[e.RowIndex].Selected = true;
        };

        dgvEmployees.MouseDown += (_, e) =>
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            DataGridView.HitTestInfo hit = dgvEmployees.HitTest(e.X, e.Y);
            if (hit.RowIndex < 0)
            {
                return;
            }

            contextMenu.Show(dgvEmployees, e.Location);
        };
    }

    /// <summary>
    ///     Opens the double-clicked row's employee in <see cref="FormEmployeeDetail" /> for
    ///     editing, then refreshes the grid once the dialog closes.
    /// </summary>
    private void DataGridView1_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvEmployees.Rows[e.RowIndex].DataBoundItem is not Employee employee)
        {
            return;
        }

        using var form = new FormEmployeeDetail(employee);
        form.ShowDialog(this);

        _loadEmployees();
    }

    /// <summary>
    ///     Re-applies the search/status filter whenever the search text changes.
    /// </summary>
    private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
    {
        ApplyFilter();
    }

    /// <summary>
    ///     Re-applies the search/status filter whenever the selected status changes.
    /// </summary>
    private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilter();
    }

    /// <summary>
    ///     Opens a non-modal <see cref="FormEmployeeDetail" /> for creating a new employee.
    /// </summary>
    private void BtnCreateNewEmployee_Click(object sender, EventArgs e)
    {
        FormEmployeeDetail formEmployeeDetail = new();

        formEmployeeDetail.Show();
    }

    // NOTE: not wired to any control — btnCreateNewEmployee.Click is bound to
    // BtnCreateNewEmployee_Click above. Left in place, unchanged, pending confirmation
    // of which handler should actually be used.
    private void btnCreateNewEmployee_Click(object sender, EventArgs e)
    {
        using var form = new FormEmployeeDetail();
        form.ShowDialog(this);

        _loadEmployees();
    }

    /// <summary>
    ///     Opens <see cref="FormImport" /> to import employees from a CSV file, then refreshes
    ///     the grid once the import dialog closes.
    /// </summary>
    private void btnImportEmployee_Click(object sender, EventArgs e)
    {
        FormImport formImport = new();

        formImport.ShowDialog(this);

        _loadEmployees();
    }

    /// <summary>
    ///     Returns the employee bound to the grid's currently selected row, if any.
    /// </summary>
    private Employee? GetSelectedEmployee()
    {
        return dgvEmployees.CurrentRow?.DataBoundItem as Employee;
    }

    /// <summary>
    ///     Opens the currently selected employee in <see cref="FormEmployeeDetail" /> for
    ///     editing, then refreshes the grid once the dialog closes.
    /// </summary>
    private void EditSelectedEmployee()
    {
        Employee? employee = GetSelectedEmployee();
        if (employee is null)
        {
            return;
        }

        using var form = new FormEmployeeDetail(employee);
        form.ShowDialog(this);

        _loadEmployees();
    }

    /// <summary>
    ///     Toggles the currently selected employee's status between active and passive and
    ///     persists the change.
    /// </summary>
    private void ToggleSelectedEmployeeStatus()
    {
        Employee? employee = GetSelectedEmployee();
        if (employee is null)
        {
            return;
        }

        employee.Status = employee.Status == Status.Active
            ? Status.Passive
            : Status.Active;

        _repository.UpdateEmployee(employee);

        _loadEmployees();
    }

    /// <summary>
    ///     Prompts for confirmation and, if confirmed, deletes the currently selected employee.
    /// </summary>
    private void DeleteSelectedEmployee()
    {
        Employee? employee = GetSelectedEmployee();
        if (employee is null)
        {
            return;
        }

        DialogResult confirmation = MessageBox.Show(
            $"Soll {employee.FirstName} {employee.LastName} wirklich gelöscht werden?",
            "Mitarbeiter löschen",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        _repository.DeleteEmployee(employee.Id);

        _loadEmployees();
    }

    /// <summary>
    ///     Reloads the full employee list from the repository and re-applies the active filter.
    /// </summary>
    private void _loadEmployees()
    {
        _employees = _repository.GetEmployees();
        ApplyFilter();
    }

    /// <summary>
    ///     Applies the current search text and status filter to <see cref="_employees" /> and
    ///     rebinds the result to the grid.
    /// </summary>
    private void ApplyFilter()
    {
        contactManagerRepositoryBindingSource.DataSource = _searchService.SearchEmployees(_employees, txtSearchEmployee.Text, cmbStatusFilter.SelectedItem);
    }

    /// <summary>
    ///     Creates a read-only, fixed-width <see cref="DataGridViewTextBoxColumn" /> bound to
    ///     the given property.
    /// </summary>
    /// <param name="dataPropertyName">Name of the bound data source property to display.</param>
    /// <param name="headerText">Column header text shown to the user.</param>
    /// <param name="width">Relative fill width used for the column.</param>
    /// <returns>The configured column.</returns>
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
}
