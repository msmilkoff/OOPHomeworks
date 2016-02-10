using System;

namespace _03.CompanyHierarchy.Interfaces
{
    interface IEmployee
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
    }
}
