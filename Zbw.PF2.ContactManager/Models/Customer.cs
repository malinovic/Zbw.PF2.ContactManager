using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

using Zbw.PF2.ContactManager.Models.Enums;

namespace Zbw.PF2.ContactManager.Models;

public class Customer : Person
{

    public string CustomerNumber { get; private set; }
    public EnumCustomerType.CustomerType CustomerType { get; private set; }
    public string CustomerCompanyName { get; private set; }
    public EnumStatus.Status CustomerStatus { get; private set; }
    protected string CustomerStatusMessage => IsActive(CustomerStatus);



    public void CheckType()
    {

    }


    public string CustomerToString()
    {
        string CustomerToString = this.FirstName + ", " + this.LastName;
        return CustomerToString;
    }



    public Customer(
        string id,
        EnumSalutation.Salutation salutation,
        string firstName,
        string lastName,
        DateOnly birthday,
        EnumSex.Sex sex,
        string title,
        Address address,
        string phoneNumberCompany,
        string phoneNumberMobile,
        string email,
        string customerNumber,
        EnumCustomerType.CustomerType customerType,
        string customerCompanyName,
        EnumStatus.Status customerStatus)
    {
        Id = id;
        Salutation = salutation;
        FirstName = firstName;
        LastName = lastName;
        Birthday = birthday;
        Sex = sex;
        Title = title;
        Address = address;
        PhoneNumberCompany = phoneNumberCompany;
        PhoneNumberMobile = phoneNumberMobile;
        Email = email;
        CustomerNumber = customerNumber;
        CustomerType = customerType;
        CustomerCompanyName = customerCompanyName;
        CustomerStatus = customerStatus;
    }
}
