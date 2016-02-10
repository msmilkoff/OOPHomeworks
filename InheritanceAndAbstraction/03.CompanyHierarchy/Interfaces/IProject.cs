using System;

namespace _03.CompanyHierarchy.Interfaces
{
    interface IProject
    {
        string ProjectName { get; set; }
        DateTime StartDate { get; set; }
        string Details { get; set; }

        void CloseProject();
    }
}
