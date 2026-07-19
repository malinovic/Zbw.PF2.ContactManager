using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Repository;

/// <summary>
///     Implements <see cref="IContactManagerRepository" /> by delegating all data access
///     to an <see cref="ICSVRepository" />.
/// </summary>
public class ContactManagerRepository(ICSVRepository csvRepository) : IContactManagerRepository
{
    private readonly ICSVRepository _csvRepository = csvRepository;

    /// <summary>
    ///     Adds a new customer to the data store.
    /// </summary>
    /// <param name="customer">The customer to add.</param>
    public void AddCustomer(Customer customer)
    {
        _csvRepository.CreateRecord(customer);
    }

    /// <summary>
    ///     Retrieves all customers from the data store.
    /// </summary>
    /// <returns>A list of all customers.</returns>
    public IList<Customer> GetCustomers()
    {
        return _csvRepository.GetRecords<Customer>();
    }

    /// <summary>
    ///     Retrieves a single customer by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the customer.</param>
    /// <returns>The matching customer, or <c>null</c> if not found.</returns>
    public Customer? GetCustomer(int id)
    {
        return _csvRepository.GetRecord<Customer>(id);
    }

    /// <summary>
    ///     Updates an existing customer record matched by their identifier.
    /// </summary>
    /// <param name="customer">The customer containing the updated values.</param>
    public void UpdateCustomer(Customer customer)
    {
        _csvRepository.UpdateRecord(customer);
    }

    /// <summary>
    ///     Removes the customer with the given identifier from the data store.
    /// </summary>
    /// <param name="id">The unique identifier of the customer to remove.</param>
    public void DeleteCustomer(int id)
    {
        _csvRepository.DeleteRecord<Customer>(id);
    }

    /// <summary>
    ///     Adds a new employee to the data store.
    /// </summary>
    /// <param name="employee">The employee to add.</param>
    public void AddEmployee(Employee employee)
    {
        _csvRepository.CreateRecord(employee);
    }

    /// <summary>
    ///     Retrieves all employees from the data store.
    /// </summary>
    /// <returns>A list of all employees.</returns>
    public IList<Employee> GetEmployees()
    {
        return _csvRepository.GetRecords<Employee>();
    }

    /// <summary>
    ///     Retrieves a single employee by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the employee.</param>
    /// <returns>The matching employee, or <c>null</c> if not found.</returns>
    public Employee? GetEmployee(int id)
    {
        return _csvRepository.GetRecord<Employee>(id);
    }

    /// <summary>
    ///     Updates an existing employee record matched by their identifier.
    /// </summary>
    /// <param name="employee">The employee containing the updated values.</param>
    public void UpdateEmployee(Employee employee)
    {
        _csvRepository.UpdateRecord(employee);
    }

    /// <summary>
    ///     Removes the employee with the given identifier from the data store.
    /// </summary>
    /// <param name="id">The unique identifier of the employee to remove.</param>
    public void DeleteEmployee(int id)
    {
        _csvRepository.DeleteRecord<Employee>(id);
    }
}
