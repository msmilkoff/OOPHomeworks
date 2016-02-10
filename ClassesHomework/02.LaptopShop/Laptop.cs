using System;
using System.Text;

namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private decimal price;
        private string manufacturer;
        private string processor;
        private string ram;
        private string graphics;
        private string hdd;
        private string screen;
        private Battery battery;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer = null, string processor = null,
            string ram = null, string hdd = null, string graphics = null, Battery battery = null,
            string screen = null)
            : this(model, price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.HDD = hdd;
            this.Graphics = graphics;
            this.Battery = battery;
            this.Screen = screen;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Model cannot be null");
                }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Manufacturer cannot be null");
                }
                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Processor cannot be null");
                }
                this.processor = value;
            }
        }
        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("RAM cannot be null");
                }
                this.ram = value;
            }
        }
        public string Graphics
        {
            get
            {
                return this.graphics;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Graphics cannot be null");
                }
                this.graphics = value;
            }
        }
        public string HDD
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException("HDD cannot be null");
                }
                this.hdd = value;
            }
        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentOutOfRangeException("Screen cannot be null");
                }
                this.screen = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be a positive number");
                }
                this.price = value;
            }
        }
        public Battery Battery { get; set; }

        public override string ToString()
        {
            StringBuilder laptopBuilder = new StringBuilder();

            laptopBuilder.AppendLine("Model: " + this.Model);
            laptopBuilder.AppendLine("Price: " + this.Price);

            if (this.Manufacturer != null)
            {
                laptopBuilder.AppendLine("manufacturer: " + this.Manufacturer);
            }
            if (this.Processor != null)
            {
                laptopBuilder.AppendLine("processor: " + this.Processor);
            }
            if (this.Ram != null)
            {
                laptopBuilder.AppendLine("RAM: " + this.Ram);
            }
            if (this.Graphics != null)
            {
                laptopBuilder.AppendLine("Graphics: " + this.Graphics);
            }
            if (this.HDD != null)
            {
                laptopBuilder.AppendLine("HDD: " + this.HDD);
            }
            if (this.Screen != null)
            {
                laptopBuilder.AppendLine("screen: " + this.Screen);
            }
            if (this.Battery != null)
            {
                laptopBuilder.Append(this.Battery.ToString());
            }

            return laptopBuilder.ToString();
        }
    }
}
