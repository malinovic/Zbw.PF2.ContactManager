using Zbw.PF2.ContactManager.Models;
using Zbw.PF2.ContactManager.Service.PasswordHash;

namespace Zbw.PF2.ContactManager.Data.Repository;

/// <summary>
///     Implements <see cref="IContactManagerRepository" /> by delegating all data access
///     to an <see cref="ICSVRepository" />.
/// </summary>
public class ContactManagerRepository(ICSVRepository csvRepository) : IContactManagerRepository
{
    private readonly IPasswordHashService _passwordHashService = new PasswordHashService();

    /// <summary>
    ///     Adds a new customer to the data store.
    /// </summary>
    /// <param name="customer">The customer to add.</param>
    public void AddCustomer(Customer customer)
    {
        csvRepository.CreateRecord(customer);
    }

    /// <summary>
    ///     Retrieves all customers from the data store.
    /// </summary>
    /// <returns>A list of all customers.</returns>
    public IList<Customer> GetCustomers()
    {
        return csvRepository.GetRecords<Customer>();
    }

    /// <summary>
    ///     Retrieves a single customer by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the customer.</param>
    /// <returns>The matching customer, or <c>null</c> if not found.</returns>
    public Customer? GetCustomer(int id)
    {
        return csvRepository.GetRecord<Customer>(id);
    }

    /// <summary>
    ///     Updates an existing customer record matched by their identifier.
    /// </summary>
    /// <param name="customer">The customer containing the updated values.</param>
    public void UpdateCustomer(Customer customer)
    {
        csvRepository.UpdateRecord(customer);
    }

    /// <summary>
    ///     Removes the customer with the given identifier from the data store.
    /// </summary>
    /// <param name="id">The unique identifier of the customer to remove.</param>
    public void DeleteCustomer(int id)
    {
        csvRepository.DeleteRecord<Customer>(id);
    }

    /// <summary>
    ///     Adds a new employee to the data store.
    /// </summary>
    /// <param name="employee">The employee to add.</param>
    public void AddEmployee(Employee employee)
    {
        csvRepository.CreateRecord(employee);
    }

    /// <summary>
    ///     Retrieves all employees from the data store.
    /// </summary>
    /// <returns>A list of all employees.</returns>
    public IList<Employee> GetEmployees()
    {
        IList<Employee> employees = [];

        try
        {
            employees = csvRepository.GetRecords<Employee>();
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
            MessageBox.Show("Achtung, Datenstamm ist korrupt.");
        }

        return employees;
    }

    /// <summary>
    ///     Retrieves a single employee by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the employee.</param>
    /// <returns>The matching employee, or <c>null</c> if not found.</returns>
    public Employee? GetEmployee(int id)
    {
        return csvRepository.GetRecord<Employee>(id);
    }

    /// <summary>
    ///     Updates an existing employee record matched by their identifier.
    /// </summary>
    /// <param name="employee">The employee containing the updated values.</param>
    public void UpdateEmployee(Employee employee)
    {
        csvRepository.UpdateRecord(employee);
    }

    /// <summary>
    ///     Removes the employee with the given identifier from the data store.
    /// </summary>
    /// <param name="id">The unique identifier of the employee to remove.</param>
    public void DeleteEmployee(int id)
    {
        csvRepository.DeleteRecord<Employee>(id);
    }

    /// <summary>
    /// Creates a contact manager user
    /// </summary>
    /// <param name="username">Username of the user</param>
    /// <param name="password">Password of the user, not hashed or salted</param>
    /// <param name="name">First and last name of the user</param>
    public void CreateUser(string username, string password, string name)
    {
        User user = new() { Username = username, Password = password, Name = name, Id = new Random().Next(1, 100000) };

        csvRepository.CreateRecord(user);
    }

    /// <summary>
    /// Checks if the user login is valid
    /// </summary>
    /// <param name="username">Username</param>
    /// <param name="hashedPassword">Password</param>
    /// <returns></returns>
    public bool CheckLoginForUser(string username, string password)
    {
        User? user = csvRepository.GetRecords<User>().FirstOrDefault(user => user.Username == username);

        if (user == null)
        {
            return false;
        }

        string hashedPassword = _passwordHashService.Hash(password);
        return _passwordHashService.Verify(password, user.Password);
    }

    /// <summary>
    /// Checks if there is an admin user in the system
    /// </summary>
    /// <returns></returns>
    public bool HasAdminUser()
    {
        IList<User> users = csvRepository.GetRecords<User>();
        return users.FirstOrDefault(x => x.Username == "admin") != null;
    }
}
