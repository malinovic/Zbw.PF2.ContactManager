using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormEmployeesPartial : Form
{
    private readonly IContactManagerRepository _repository;
    private IList<Employee> _employees = [];

    public FormEmployeesPartial(IContactManagerRepository contactManagerRepository)
    {
        InitializeComponent();

        _repository = contactManagerRepository;

        ThemeManager.ApplyDataGridViewStyles(dgvEmployees);

        ConfigureGridColumns();
        ConfigureRowContextMenu();

        dgvEmployees.CellDoubleClick += DataGridView1_CellDoubleClick;
        dgvEmployees.Resize += (_, _) => FillRowsToAvailableHeight();

        cmbStatusFilter.Items.Add("Alle");
        foreach (Status status in Enum.GetValues<Status>())
        {
            cmbStatusFilter.Items.Add(status);
        }
        cmbStatusFilter.SelectedIndex = 0;

        _employees = _repository.GetEmployees();
        ApplyFilter();
    }

    private void BtnCreateNewEmployee_Click(object sender, EventArgs e)
    {
        using FormAddEmployee formAddEmployee = new();

        formAddEmployee.Show();

        _employees = _repository.GetEmployees();
    }

    private void TxtSearchEmployee_TextChanged(object sender, EventArgs e)
    {
        ApplyFilter();
    }

    private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilter();
    }

    private void DataGridView1_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvEmployees.Rows[e.RowIndex].DataBoundItem is not Employee employee)
        {
            return;
        }

        using var form = new FormAddEmployee(employee);
        form.ShowDialog(this);

        _employees = _repository.GetEmployees();
        ApplyFilter();
    }

    /// <summary>
    ///     Builds the grid's columns from just the fields most useful for scanning the employee
    ///     list at a glance; double-clicking a row opens <see cref="FormAddEmployee" /> for the
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
            CreateColumn("EmployeeStatus", "Status", 120),
            CreateColumn("EmployeeDateOfHire", "Eingestellt am", 150));

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

        var menuDelete = new ToolStripMenuItem("Löschen");
        menuDelete.Click += (_, _) => DeleteSelectedEmployee();

        var contextMenu = new ContextMenuStrip();
        contextMenu.Items.Add(menuEdit);
        contextMenu.Items.Add(menuDelete);

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

    private Employee? GetSelectedEmployee()
    {
        return dgvEmployees.CurrentRow?.DataBoundItem as Employee;
    }

    private void EditSelectedEmployee()
    {
        Employee? employee = GetSelectedEmployee();
        if (employee is null)
        {
            return;
        }

        using var form = new FormAddEmployee(employee);
        form.ShowDialog(this);

        _employees = _repository.GetEmployees();
        ApplyFilter();
    }

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

    private void ApplyFilter()
    {
        IEnumerable<Employee> filtered = _employees;

        string search = txtSearchEmployee.Text.Trim();
        if (!string.IsNullOrEmpty(search))
        {
            filtered = filtered.Where(employee =>
                employee.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                employee.LastName.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                employee.EmployeeNumber.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                employee.Department.Contains(search, StringComparison.OrdinalIgnoreCase));
        }

        if (cmbStatusFilter.SelectedItem is Status status)
        {
            filtered = filtered.Where(employee => employee.Status == status);
        }

        contactManagerRepositoryBindingSource.DataSource = filtered.ToList();
        FillRowsToAvailableHeight();
    }

    /// <summary>
    ///     DataGridView has no built-in "fill" mode for row height (unlike
    ///     <see cref="DataGridViewAutoSizeColumnsMode.Fill" /> for columns), so with few results it
    ///     would otherwise leave empty space below the last row. This stretches rows to consume the
    ///     grid's full available height, never shrinking below the normal row height.
    /// </summary>
    private void FillRowsToAvailableHeight()
    {
        if (dgvEmployees.Rows.Count == 0)
        {
            return;
        }

        int availableHeight = dgvEmployees.ClientSize.Height - dgvEmployees.ColumnHeadersHeight;
        int rowHeight = Math.Max(dgvEmployees.RowTemplate.Height, availableHeight / dgvEmployees.Rows.Count);

        foreach (DataGridViewRow row in dgvEmployees.Rows)
        {
            row.Height = rowHeight;
        }
    }
}
