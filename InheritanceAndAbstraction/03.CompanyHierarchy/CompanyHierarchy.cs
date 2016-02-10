using System;
using System.Collections.Generic;

namespace _03.CompanyHierarchy
{
    class CompanyHierarchy
    {
        static void Main()
        {

            List<Project> projects = new List<Project>
            {
                new Project("RPG", new DateTime(2015, 6, 7), "The new Skyrim"),
                new Project("FPS", new DateTime(2015, 4, 5), "The new CS"),
                new Project("MMORPG", new DateTime(2015, 1, 2), "The new WoW")
            };

            List<Employee> devs = new List<Employee>
            {
                new Developer(3, "Jon", "Skeet", 950m, projects),
                new Developer(2, "Jenny", "Skeet", 1000m, projects)
            };

            Manager devManager = new Manager(15, "Pesho", "Peshev", 1200m, Departament.Production, devs);

            List<Sale> sales = new List<Sale>
            {
                new Sale("Server PC", new DateTime(2015, 6, 12), 1800m),
                new Sale("SSD", new DateTime(2015, 6, 13), 250m),
                new Sale("Laptop", new DateTime(2015, 6, 14), 850m)
            };

            List<Employee> salesEmployees = new List<Employee>
            {
                new SalesEmployee(243501, "Robert", "Baratheon", 1850m, sales),
                new SalesEmployee(654854, "Ned", "Stark", 1650m, sales)
            };

            Manager salesManager = new Manager(1, "Gosho", "Goshev", 2000m, Departament.Sales, salesEmployees);

            var peter = new SalesEmployee(5135, "Peter", "Petrov", 1200m, 
                new List<Sale>
                {
                    new Sale("BMW", new DateTime(2015,6,13), 10500m)
                });

            var bob = new Developer(4255, "Bob", "Smith", 990m,
                new List<Project>
                {
                    new Project("Alpha Centauri", new DateTime(2015, 3, 3), "Star tracking System")
                });

            List<Employee> workers = new List<Employee> {devManager, salesManager, peter, bob};

            foreach (Employee worker in workers)
            {
                Console.WriteLine(worker);
            }
        }
    }
}
