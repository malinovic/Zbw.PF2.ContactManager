using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Repository;

/// <summary>
///     The base repository interface for the Contact Manager application.
///     This interface defines the contract for data access operations related to managing customers and employess,
///     including CRUD (Create, Read, Update, Delete) operations and any other necessary data retrieval methods.
/// </summary>
public interface IContactManagerRepository
{
    // Customer CRUD
    void AddCustomer(Customer customer);
    IList<Customer> GetCustomers();
    Customer? GetCustomer(int id);
    void UpdateCustomer(Customer customer);
    void DeleteCustomer(int id);

    // Employee CRUD
    void AddEmployee(Employee employee);
    IList<Employee> GetEmployees();
    Employee? GetEmployee(int id);
    void UpdateEmployee(Employee employee);
    void DeleteEmployee(int id);
}