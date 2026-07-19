using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Repository;

/// <summary>
///     Defines the contract for data access operations in the Contact Manager application,
///     covering full CRUD (Create, Read, Update, Delete) for both customers and employees.
/// </summary>
public interface IContactManagerRepository
{
    // Customer CRUD

    /// <summary>
    ///     Adds a new customer to the data store.
    /// </summary>
    /// <param name="customer">The customer to add.</param>
    void AddCustomer(Customer customer);

    /// <summary>
    ///     Retrieves all customers from the data store.
    /// </summary>
    /// <returns>A list of all customers.</returns>
    IList<Customer> GetCustomers();

    /// <summary>
    ///     Retrieves a single customer by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the customer.</param>
    /// <returns>The matching customer, or <c>null</c> if not found.</returns>
    Customer? GetCustomer(int id);

    /// <summary>
    ///     Updates an existing customer record matched by their identifier.
    /// </summary>
    /// <param name="customer">The customer containing the updated values.</param>
    void UpdateCustomer(Customer customer);

    /// <summary>
    ///     Removes the customer with the given identifier from the data store.
    /// </summary>
    /// <param name="id">The unique identifier of the customer to remove.</param>
    void DeleteCustomer(int id);

    // Employee CRUD

    /// <summary>
    ///     Adds a new employee to the data store.
    /// </summary>
    /// <param name="employee">The employee to add.</param>
    void AddEmployee(Employee employee);

    /// <summary>
    ///     Retrieves all employees from the data store.
    /// </summary>
    /// <returns>A list of all employees.</returns>
    IList<Employee> GetEmployees();

    /// <summary>
    ///     Retrieves a single employee by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the employee.</param>
    /// <returns>The matching employee, or <c>null</c> if not found.</returns>
    Employee? GetEmployee(int id);

    /// <summary>
    ///     Updates an existing employee record matched by their identifier.
    /// </summary>
    /// <param name="employee">The employee containing the updated values.</param>
    void UpdateEmployee(Employee employee);

    /// <summary>
    ///     Removes the employee with the given identifier from the data store.
    /// </summary>
    /// <param name="id">The unique identifier of the employee to remove.</param>
    void DeleteEmployee(int id);
}
