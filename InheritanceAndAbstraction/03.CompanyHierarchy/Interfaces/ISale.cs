using System;

namespace _03.CompanyHierarchy.Interfaces
{
    interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}
