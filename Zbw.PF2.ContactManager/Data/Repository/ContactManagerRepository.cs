using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Repository;

public class ContactManagerRepository(ICSVRepository csvRepository) : IContactManagerRepository
{
    private readonly ICSVRepository _csvRepository = csvRepository;

    public void AddCustomer(Customer customer)
    {
        _csvRepository.CreateRecord(customer);
    }

    public IList<Customer> GetCustomers()
    {
        return _csvRepository.GetRecords<Customer>();
    }

    public Customer? GetCustomer(int id)
    {
        return _csvRepository.GetRecord<Customer>(id);
    }

    public void UpdateCustomer(Customer customer)
    {
        _csvRepository.UpdateRecord(customer);
    }

    public void DeleteCustomer(int id)
    {
        _csvRepository.DeleteRecord<Customer>(id);
    }

    public void AddEmployee(Employee employee)
    {
        _csvRepository.CreateRecord(employee);
    }

    public IList<Employee> GetEmployees()
    {
        return _csvRepository.GetRecords<Employee>();
    }

    public Employee? GetEmployee(int id)
    {
        return _csvRepository.GetRecord<Employee>(id);
    }

    public void UpdateEmployee(Employee employee)
    {
        _csvRepository.UpdateRecord(employee);
    }

    public void DeleteEmployee(int id)
    {
        _csvRepository.DeleteRecord<Employee>(id);
    }
}