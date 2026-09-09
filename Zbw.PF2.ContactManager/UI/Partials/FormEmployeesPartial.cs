using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.Search;

namespace Zbw.PF2.ContactManager.UI.Partials;

/// <summary>
///     Displays the list of employees in a searchable, filterable grid, with actions to
///     create, edit, toggle the status of, and delete employees.
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

        _employees = _repository.GetEmployees();
        ApplyFilter();
    }

    /// <summary>
    ///     Opens the form for creating a new employee.
    /// </summary>
    private void BtnCreateNewEmployee_Click(object sender, EventArgs e)
    {
        FormEmployeeDetail formEmployeeDetail = new();

        formEmployeeDetail.Show();
    }

    /// <summary>
    ///     Reapplies the search/status filter whenever the search text changes.
    /// </summary>
    private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
    {
        ApplyFilter();
    }

    /// <summary>
    ///     Reapplies the search/status filter whenever the status dropdown selection changes.
    /// </summary>
    private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilter();
    }

    /// <summary>
    ///     Opens the double-clicked row's employee for editing.
    /// </summary>
    private void DataGridView1_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvEmployees.Rows[e.RowIndex].DataBoundItem is not Employee employee)
        {
            return;
        }

        using var form = new FormEmployeeDetail(employee);
        form.ShowDialog(this);

        _employees = _repository.GetEmployees();
        ApplyFilter();
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
    ///     Wires up a right-click context menu (edit / toggle status / delete) on grid rows.
    ///     Defined in code alongside <see cref="ConfigureGridColumns" /> so it survives designer
    ///     regeneration.
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
    ///     Gets the employee bound to the currently selected grid row, if any.
    /// </summary>
    /// <returns>The selected employee, or <c>null</c> if no row is selected.</returns>
    private Employee? GetSelectedEmployee()
    {
        return dgvEmployees.CurrentRow?.DataBoundItem as Employee;
    }

    /// <summary>
    ///     Opens the currently selected employee for editing.
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

        _employees = _repository.GetEmployees();
        ApplyFilter();
    }

    /// <summary>
    ///     Toggles the currently selected employee's status between active and passive.
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

        _employees = _repository.GetEmployees();
        ApplyFilter();
    }

    /// <summary>
    ///     Deletes the currently selected employee, after confirming with the user.
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

        _employees = _repository.GetEmployees();
        ApplyFilter();
    }

    /// <summary>
    ///     Creates a read-only grid column bound to the given property.
    /// </summary>
    /// <param name="dataPropertyName">The name of the bound property on the row's data object.</param>
    /// <param name="headerText">The column header text.</param>
    /// <param name="width">The relative fill width used by <see cref="DataGridViewAutoSizeColumnsMode.Fill" />.</param>
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

    /// <summary>
    ///     Reapplies the current search term and status filter to the grid's data source.
    /// </summary>
    private void ApplyFilter()
    {
        contactManagerRepositoryBindingSource.DataSource = _searchService.SearchEmployees(_employees, txtSearchEmployee.Text, cmbStatusFilter.SelectedItem);
    }

    /// <summary>
    ///     Opens the form for creating a new employee.
    /// </summary>
    private void btnCreateNewEmployee_Click(object sender, EventArgs e)
    {
        using var form = new FormEmployeeDetail();
        form.ShowDialog(this);

        _employees = _repository.GetEmployees();
        ApplyFilter();
    }
}