using System;
using System.Collections.Generic;

namespace _03.CompanyHierarchy.Interfaces
{
    interface ISalesEmployee
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
        List<Sale> Sales { get; set; }
    }
}
