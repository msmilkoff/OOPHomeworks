using System;
using System.Collections.Generic;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class Developer : Employee, IDeveloper
    {
        private List<Project> projects; 

        public Developer(int id, string firstName, string lastName, decimal salary, List<Project> projects)
            : base(id, firstName, lastName, salary)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }

        public override string ToString()
        {
            return string.Format("--->Eployee ID - [{0}]\n--->Employee name: {1} {2}\n--->Employee Projects:\n{3}",
                this.ID, this.FirstName, this.LastName,
                string.Join("\n ", this.Projects));
        }
    }
}
