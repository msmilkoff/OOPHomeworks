using System;

namespace _02.LaptopShop
{
    class Battery
    {
        private string type;
        private double life;

        public Battery(string type)
        {
            this.Type = type;
        }

        public Battery(string type, double life)
            : this(type)
        {
            this.Life = life;

        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Battery model cannot be null;");
                }
                this.type = value;
            }
        }

        public double Life
        {
            get
            {
                return this.life;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be a  positive number");
                }
                this.life = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Battery Type: {0}\nBattery Life: {1}", this.Type, this.Life);
        }
    }
}
