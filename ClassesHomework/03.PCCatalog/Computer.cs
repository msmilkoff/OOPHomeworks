using System;
using System.Collections.Generic;
using System.Globalization;

namespace _03.PCCatalog
{
    class Computer
    {
        private string name;
        private decimal price;
        private List<Component> components;

        public Computer(string name)
        {
            this.Name = name;
        }
        public Computer(string name, List<Component> components) : this (name)
        {
            this.Components = components;
        }
        public Computer()
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Computer name cannot be empty");
                }
                this.name = value;
            }
        }

        public List<Component> Components { get; set; }

        public decimal TotalComponentsPrice(List<Component> components)
        {
            decimal totalPrice = 0m;
            if (this.Components != null)
            {
                foreach (var cp in components)
                {
                    totalPrice += cp.Price;
                }
            }

            return totalPrice;
        }

        public void PrintInfo()
        {
            CultureInfo bg = new CultureInfo("bg-BG");

            Console.WriteLine("{0}:\n", this.Name);
            Console.WriteLine("Components:");
            foreach (var component in this.Components)
            {
                Console.Write("    {0}, {1}, Price -----> ", component.Name, component.Details);
                Console.WriteLine(component.Price.ToString("c", bg));
            }
            Console.WriteLine();
            Console.WriteLine("     Total Computer Price: {0}",
                TotalComponentsPrice(this.Components).ToString("c", bg));

        }
    }
}
