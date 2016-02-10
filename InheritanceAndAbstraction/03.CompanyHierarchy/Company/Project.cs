using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    public class Project : IProject
    {
        private string projectName;
        private DateTime startDate;
        private string details;
        private readonly bool isOpen;

        public Project(string projectName, DateTime startDate, string details, bool isOpen = true)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.Details = details;
            this.IsOpen = isOpen;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Project name cannot be empty.");
                }

                this.projectName = value;
            }
        }

        public string Details { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsOpen { get; set; }

        public void CloseProject()
        {
            this.IsOpen = false;
        }

        public override string ToString()
        {
            return string.Format("-{0}\n\tStart date: {1}\n\tProject state: {2}\n\tDetails: {3}\n",
                this.ProjectName, this.StartDate,
                IsOpen == true ? "Open" : "Closed", this.Details);
        }
    }
}
