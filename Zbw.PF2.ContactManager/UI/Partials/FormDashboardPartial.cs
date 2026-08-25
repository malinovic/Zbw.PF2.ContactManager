using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.UI.Partials;

/// <summary>
/// Displays an overview of the currently stored customers and employees:
/// summary statistics, recently added contacts and data-quality hints
/// (missing phone numbers, possible duplicates).
/// </summary>
public partial class FormDashboardPartial : Form
{
    private const int RecentEntriesCount = 7;

    private readonly IContactManagerRepository _repository;

    /// <summary>
    /// Initializes a new instance of the <see cref="FormDashboardPartial"/> class.
    /// </summary>
    /// <param name="repository">The repository used to read customer and employee data.</param>
    public FormDashboardPartial(IContactManagerRepository repository)
    {
        InitializeComponent();

        _repository = repository;

        LoadDashboardData();
    }

    /// <summary>
    /// Reads the current customer and employee data from the repository
    /// and fills the dashboard with statistics, recent entries and data-quality hints.
    /// </summary>
    private void LoadDashboardData()
    {
        IList<Customer> customers = _repository.GetCustomers();
        IList<Employee> employees = _repository.GetEmployees();

        int activeCustomers = customers.Count(c => c.CustomerStatus == Status.Active);
        int activeEmployees = employees.Count(e => e.EmployeeStatus == Status.Active);
        int inactiveCustomers = customers.Count - activeCustomers;
        int inactiveEmployees = employees.Count - activeEmployees;

        labelStatTotalValue.Text = (customers.Count + employees.Count).ToString();
        labelStatCustomersValue.Text = activeCustomers.ToString();
        labelStatEmployeesValue.Text = activeEmployees.ToString();
        labelStatInactiveValue.Text = (inactiveCustomers + inactiveEmployees).ToString();

        LoadRecentContacts(customers, employees);
        LoadNeedsAttention(customers, employees);
    }

    private void LoadRecentContacts(IList<Customer> customers, IList<Employee> employees)
    {
        listBoxRecentContacts.Items.Clear();

        var recent = customers
            .Select(c => (Name: $"{c.FirstName} {c.LastName}", Type: "Kunde", c.Id))
            .Concat(employees.Select(e => (Name: $"{e.FirstName} {e.LastName}", Type: "Mitarbeiter", e.Id)))
            .OrderByDescending(x => x.Id)
            .Take(RecentEntriesCount);

        foreach (var entry in recent)
        {
            listBoxRecentContacts.Items.Add($"{entry.Name}   —   {entry.Type}");
        }

        if (listBoxRecentContacts.Items.Count == 0)
        {
            listBoxRecentContacts.Items.Add("Keine Kontakte erfasst");
        }
    }

    private void LoadNeedsAttention(IList<Customer> customers, IList<Employee> employees)
    {
        var allContacts = customers.Cast<Person>().Concat(employees.Cast<Person>()).ToList();

        List<string> missingPhone = allContacts
            .Where(p => string.IsNullOrWhiteSpace(p.PhoneNumberMobile) && string.IsNullOrWhiteSpace(p.PhoneNumberCompany))
            .Select(p => $"{p.FirstName} {p.LastName}")
            .ToList();

        List<string> duplicates = allContacts
            .GroupBy(p => (p.FirstName.Trim().ToLower(), p.LastName.Trim().ToLower()))
            .Where(g => g.Count() > 1)
            .Select(g => $"{g.Key.Item1} {g.Key.Item2} ({g.Count()}x erfasst)")
            .ToList();

        listBoxMissingPhone.Items.Clear();
        listBoxMissingPhone.Items.AddRange(missingPhone.Count == 0
            ? new object[] { "Keine Einträge" }
            : missingPhone.ToArray());

        listBoxDuplicates.Items.Clear();
        listBoxDuplicates.Items.AddRange(duplicates.Count == 0
            ? new object[] { "Keine Einträge" }
            : duplicates.ToArray());
    }

    private void labelMissingPhoneTitle_Click(object sender, EventArgs e)
    {

    }

    private void listBoxRecentContacts_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void listBoxMissingPhone_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}