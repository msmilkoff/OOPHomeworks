using System;
using System.Collections.Generic;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class SalesEmployee : Employee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, List<Sale> sales)
            : base(id, firstName, lastName, salary)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }

        public override string ToString()
        {
            return string.Format("--->Employee ID: [{0}]\n--->Employee name: {1} {2}\n--->Employee Sales:\n {3}\n",
                this.ID, this.FirstName, this.LastName,
                 string.Join("\n ", this.Sales));
        }
    }
}
