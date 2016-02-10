using System;

namespace _03.CompanyHierarchy.Interfaces
{
    interface ICustomer
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal NetPurchaseAmount { get; set; }
    }
}
