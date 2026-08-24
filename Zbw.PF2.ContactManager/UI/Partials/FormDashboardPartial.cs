using Zbw.PF2.ContactManager.Core.Constants;
using Zbw.PF2.ContactManager.Data.Repository;
using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.UI.Partials;

/// <summary>
/// Displays an overview of the currently stored customers and employees,
/// including how many of each are active/inactive and the most recently added entries.
/// </summary>
public partial class FormDashboardPartial : Form
{
    private const int RecentEntriesCount = 5;

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
    /// and displays counts and recently added entries on the dashboard.
    /// </summary>
    private void LoadDashboardData()
    {
        IList<Customer> customers = _repository.GetCustomers();
        IList<Employee> employees = _repository.GetEmployees();

        LoadEmployeeStats(employees);
        LoadCustomerStats(customers);

        LoadRecentEmployees(employees);
        LoadRecentCustomers(customers);
    }

    private void LoadEmployeeStats(IList<Employee> employees)
    {
        int total = employees.Count;
        int active = employees.Count(e => e.EmployeeStatus == Status.Active);
        int inactive = total - active;

        labelEmployeesTotal.Text = $"Gesamt: {total}";
        labelEmployeesActive.Text = $"Aktiv: {active}";
        labelEmployeesInactive.Text = $"Inaktiv: {inactive}";
    }

    private void LoadCustomerStats(IList<Customer> customers)
    {
        int total = customers.Count;
        int active = customers.Count(c => c.CustomerStatus == Status.Active);
        int inactive = total - active;

        labelCustomersTotal.Text = $"Gesamt: {total}";
        labelCustomersActive.Text = $"Aktiv: {active}";
        labelCustomersInactive.Text = $"Inaktiv: {inactive}";
    }

    private void LoadRecentEmployees(IList<Employee> employees)
    {
        listBoxRecentEmployees.Items.Clear();

        var recentEmployees = employees
            .OrderByDescending(e => e.Id)
            .Take(RecentEntriesCount);

        foreach (Employee employee in recentEmployees)
        {
            listBoxRecentEmployees.Items.Add($"{employee.FirstName} {employee.LastName}");
        }

        if (listBoxRecentEmployees.Items.Count == 0)
        {
            listBoxRecentEmployees.Items.Add("Keine Mitarbeiter erfasst");
        }
    }

    private void LoadRecentCustomers(IList<Customer> customers)
    {
        listBoxRecentCustomers.Items.Clear();

        var recentCustomers = customers
            .OrderByDescending(c => c.Id)
            .Take(RecentEntriesCount);

        foreach (Customer customer in recentCustomers)
        {
            listBoxRecentCustomers.Items.Add($"{customer.FirstName} {customer.LastName}");
        }

        if (listBoxRecentCustomers.Items.Count == 0)
        {
            listBoxRecentCustomers.Items.Add("Keine Kunden erfasst");
        }
    }
}