using System;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName 
        {
            get{return this.productName;}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Product name cannot be empty.");
                }

                this.productName = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(" Sale price cannot be negative");
                }
                this.price = value;
            }
        }

        public DateTime Date { get; set; }

        public override string ToString()
        {
            return String.Format("\n Product name: {0} \nProduct Date: {1}\nProduct Price: {2}",
                this.ProductName, this.Date, this.Price);
        }
    }
}
