using System;

namespace _03.PCCatalog
{
    class Component
    {
        string name;
        decimal price;
        string details;

        public Component(string name, decimal price, string details = null) 
            : this(name, price)
        {
            this.Details = details;
        }

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Component name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Component price must be a positive number");
                }
                this.price = value;
            }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("Component details cannot be empty");
                }
                this.details = value;
            }
        }
    }
}