using Zbw.PF2.ContactManager.Models;

namespace Zbw.PF2.ContactManager.Data.Repository;

public class ContactManagerRepository(ICSVRepository csvRepository) : IContactManagerRepository
{
    private readonly ICSVRepository _csvRepository = csvRepository;

    public void AddCustomer(Customer customer)
    {
        _csvRepository.CreateRecord(customer);
    }

    public void AddEmployee(Employee employee)
    {
        _csvRepository.CreateRecord(employee);
    }

    public IList<Customer> GetCustomers()
    {
        return _csvRepository.GetRecords<Customer>();
    }

    public IList<Employee> GetEmployees()
    {
        return _csvRepository.GetRecords<Employee>();
    }
}