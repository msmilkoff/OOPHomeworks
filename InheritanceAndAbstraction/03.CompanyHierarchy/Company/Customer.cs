using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class Customer : Person, ICustomer
    {
        private decimal netPurchaseAmount;

        public Customer(int id, string firstName, string lastName, decimal netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public decimal NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Net amount cannot be negative.");
                }
                this.netPurchaseAmount = value;
            }
        }

        public override string ToString()
        {
            return string.Format("[{0}] {1}, {2}, NPA = {3}",
                this.ID, this.FirstName, this.LastName, this.NetPurchaseAmount);
        }
    }
}
