using System;
using System.Collections.Generic;
using System.Text;

namespace Zbw.PF2.ContactManager.Models.Enums;

internal static class CustomEnums
{
    // Enums for class Person
    public enum Salutation { Herr, Frau,};
    public enum Sex {Mann, Frau };
    public enum Status { aktiv, passiv }


    //Enums for class Employee
    public enum EmployeeSeniorLevel {Level0 = 0, Level1 = 1, Level2 = 2, Level3 = 3, Level4 = 4, Level5 = 5 };

    public enum CustomerType { Privat, Firma}


    //Enums for class Customer
    public enum CustomerStatus { aktiv, passiv};

    
}
