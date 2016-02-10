using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    public enum Departament
    {
        Production,
        Accounting,
        Sales,
        Marketing
    }

    public abstract class Employee : Person, IEmployee
    {
        private decimal salary;
        private Departament departament;

        protected Employee(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        protected Employee(int id, string firstName, string lastName, decimal salary, Departament departament)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Departament = departament;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 400)
                {
                    throw new ArgumentOutOfRangeException("Salary must be at least 400");
                }

                this.salary = value;
            }
        }

        public Departament Departament { get; set; }

    }
}
