using System;
using System.Collections.Generic;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(int id, string firstName, string lastName, decimal salary,
            Departament departament, List<Employee> employees)
            : base(id, firstName, lastName, salary, departament)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1} {2}\n-Salary: {3}\n-Departament: {4}\n-Employees:\n{5}",
                this.ID, this.FirstName, this.LastName, this.Salary,
                this.Departament, string.Join("\n ", this.Employees));
        }
    }
}
