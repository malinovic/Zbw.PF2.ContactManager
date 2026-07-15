using System;
using System.Collections.Generic;
using System.Text;

namespace Zbw.PF2.ContactManager.Models.Enums;

internal class Enums
{
    // Enums for class Person
    public enum Salutation { Herr, Frau,};
    public enum Sex {Mann, Frau };


    //Enums for class Employee
    public enum EmployeeStatus { aktiv, passiv}
    public enum EmployeeSeniorLevel {Level0 = 0, Level1 = 1, Level2 = 2, Level3 = 3, Level4 = 4, Level5 = 5 };

    //Enums for class Customer
    public enum CustomerStatus { aktiv, passiv};

    
}
