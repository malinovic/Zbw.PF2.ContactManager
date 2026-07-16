using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

using Zbw.PF2.ContactManager.Models.Enums;

using static Zbw.PF2.ContactManager.Models.Enums.CustomEnums;

namespace Zbw.PF2.ContactManager.Models;

internal class Customer : Person
{
    // Properties

    public string CustomerNumber { get; private set; }
    public CustomEnums.CustomerType CustomerType { get; private set; }
    public string CustomerCompanyName { get; private set; }
    public CustomEnums.Status CustomerStatus { get; private set; }
    protected string CustomerStatusMessage => IsActive(CustomerStatus);



    // Methods

    public void CheckType()
    {

    }


    public string CustomerToString()
    {
        string CustomerToString = this.FirstName + ", " + this.LastName;
        return CustomerToString;
    }



    // Costructor

    public Customer(
        string id,
        CustomEnums.Salutation salutation,
        string firstName,
        string lastName,
        DateOnly birthday,
        CustomEnums.Sex sex,
        string title,
        Address address,
        string phoneNumberCompany,
        string phoneNumberMobile,
        string email,
        string customerNumber,
        CustomEnums.CustomerType customerType,
        string customerCompanyName,
        CustomEnums.Status customerStatus)
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
