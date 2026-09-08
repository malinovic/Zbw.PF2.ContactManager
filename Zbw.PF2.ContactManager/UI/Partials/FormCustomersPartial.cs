using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Core.Theme;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.Import;
using Zbw.PF2.ContactManager.Service.Search;
using Zbw.PF2.ContactManager.Validation.ValidationCustomer;

namespace Zbw.PF2.ContactManager.UI.Partials;

public partial class FormCustomersPartial : Form
{
    private readonly IContactManagerRepository _repository;
    private readonly IImportService _importService = new ImportService();
    private IList<Customer> _Customers = [];
    private ISearchService _searchService = new SearchService();

    /// <summary>
    ///     Initializes a new instance of <see cref="FormCustomersPartial" /> and loads the Customer list.
    /// </summary>
    /// <param name="contactManagerRepository">The repository used to load and persist Customers.</param>
    public FormCustomersPartial(IContactManagerRepository contactManagerRepository)
    {
        InitializeComponent();

        _repository = contactManagerRepository;

        ThemeManager.ApplyButtonStyles(btnImportCustomer);
        ThemeManager.ApplyDataGridViewStyles(dgvCustomers);

        ConfigureGridColumns();
        ConfigureRowContextMenu();

        dgvCustomers.CellDoubleClick += DataGridView1_CellDoubleClick;

        cmbStatusFilter.Items.Add("Alle");
        foreach (Status status in Enum.GetValues<Status>())
        {
            cmbStatusFilter.Items.Add(status);
        }
        cmbStatusFilter.SelectedIndex = 0;

        _Customers = _repository.GetCustomers();
        ApplyFilter();
    }

    private void BtnCreateNewCustomer_Click(object sender, EventArgs e)
    {
        FormCustomerDetail formCustomerDetail = new();

        formCustomerDetail.Show();
    }

    private void TxtSearchCustomer_TextChanged(object sender, EventArgs e)
    {
        ApplyFilter();
    }

    private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
    {
        ApplyFilter();
    }

    private void DataGridView1_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || dgvCustomers.Rows[e.RowIndex].DataBoundItem is not Customer Customer)
        {
            return;
        }

        using var form = new FormCustomerDetail(Customer);
        form.ShowDialog(this);

        _Customers = _repository.GetCustomers();
        ApplyFilter();
    }

    /// <summary>
    ///     Builds the grid's columns from just the fields most useful for scanning the Customer
    ///     list at a glance; double-clicking a row opens <see cref="FormCustomerDetailPartial" /> for the
    ///     full set of details and editing. Defined in code (rather than the Designer file) so it
    ///     survives the WinForms designer regenerating <c>InitializeComponent</c>.
    /// </summary>
    private void ConfigureGridColumns()
    {
        dgvCustomers.AutoGenerateColumns = false;
        dgvCustomers.Columns.Clear();
        dgvCustomers.Columns.AddRange(
            CreateColumn("FirstName", "Vorname", 150),
            CreateColumn("LastName", "Nachname", 150),
            CreateColumn("CustomerNumber", "Kundenr.", 140),
            CreateColumn("Email", "E-Mail", 220),
            CreateColumn("CustomerStatus", "Status", 120)
           );

        // Stretch the columns to always fill the grid's full width instead of leaving empty
        // space on wide windows; the basic widths above become the relative fill proportions.
        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    /// <summary>
    ///     Wires up a right-click context menu (edit / delete) on grid rows. Defined in code
    ///     alongside <see cref="ConfigureGridColumns" /> so it survives designer regeneration.
    /// </summary>
    private void ConfigureRowContextMenu()
    {
        var menuEdit = new ToolStripMenuItem("Bearbeiten");
        menuEdit.Click += (_, _) => EditSelectedCustomer();

        var menuToggleStatus = new ToolStripMenuItem();
        menuToggleStatus.Click += (_, _) => ToggleSelectedCustomerStatus();

        var menuDelete = new ToolStripMenuItem("Löschen");
        menuDelete.Click += (_, _) => DeleteSelectedCustomer();

        var contextMenu = new ContextMenuStrip();
        contextMenu.Items.Add(menuEdit);
        contextMenu.Items.Add(menuToggleStatus);
        contextMenu.Items.Add(menuDelete);

        contextMenu.Opening += (_, e) =>
        {
            Customer? Customer = GetSelectedCustomer();
            if (Customer is null)
            {
                e.Cancel = true;
                return;
            }

            menuToggleStatus.Text = Customer.CustomerStatus == Status.Active
                ? "Deaktivieren"
                : "Aktivieren";
        };

        dgvCustomers.CellMouseDown += (_, e) =>
        {
            if (e.RowIndex < 0 || e.Button != MouseButtons.Right)
            {
                return;
            }

            dgvCustomers.ClearSelection();
            dgvCustomers.Rows[e.RowIndex].Selected = true;
        };

        dgvCustomers.MouseDown += (_, e) =>
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            DataGridView.HitTestInfo hit = dgvCustomers.HitTest(e.X, e.Y);
            if (hit.RowIndex < 0)
            {
                return;
            }

            contextMenu.Show(dgvCustomers, e.Location);
        };
    }

    private Customer? GetSelectedCustomer()
    {
        return dgvCustomers.CurrentRow?.DataBoundItem as Customer;
    }

    private void EditSelectedCustomer()
    {
        Customer? Customer = GetSelectedCustomer();
        if (Customer is null)
        {
            return;
        }

        using var form = new FormCustomerDetail(Customer);
        form.ShowDialog(this);

        _Customers = _repository.GetCustomers();
        ApplyFilter();
    }

    private void ToggleSelectedCustomerStatus()
    {
        Customer? customer = GetSelectedCustomer();
        if (customer is null)
        {
            return;
        }

        customer.CustomerStatus = customer.CustomerStatus == Status.Active
            ? Status.Passive
            : Status.Active;

        _repository.UpdateCustomer(customer);

        _Customers = _repository.GetCustomers();
        ApplyFilter();
    }

    private void DeleteSelectedCustomer()
    {
        Customer? Customer = GetSelectedCustomer();
        if (Customer is null)
        {
            return;
        }

        DialogResult confirmation = MessageBox.Show(
            $"Soll {Customer.FirstName} {Customer.LastName} wirklich gelöscht werden?",
            "Kunde löschen",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (confirmation != DialogResult.Yes)
        {
            return;
        }

        _repository.DeleteCustomer(Customer.Id);

        _Customers = _repository.GetCustomers();
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
        contactManagerRepositoryBindingSource.DataSource = _searchService.SearchCustomers(_Customers, txtSearchCustomers.Text, cmbStatusFilter.SelectedItem);
    }

    private void btnCreateNewCustomer_Click(object sender, EventArgs e)
    {
        using var form = new FormCustomerDetail();
        form.ShowDialog(this);

        _Customers = _repository.GetCustomers();
        ApplyFilter();
    }

    private void btnImportCustomer_Click(object sender, EventArgs e)
    {
        using OpenFileDialog dialog = new() { Filter = "vCard Dateien (*.vcf)|*.vcf" };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        CustomerInput prefill;
        try
        {
            prefill = _importService.ImportCustomer(dialog.FileName);
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Die vCard konnte nicht importiert werden: {ex.Message}",
                "Fehler",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return;
        }

        using var form = new FormCustomerDetail(prefill);
        form.ShowDialog(this);

        _Customers = _repository.GetCustomers();
        ApplyFilter();
    }
}
