using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PC_Catalog
{
    class Component
    {
        private string name;
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                this.name = value;
            }
        }

        public decimal Price 
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.price = value;
            } 
        }

        public string Details { get; set; }

        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, decimal price, string details) : this(name, price)
        {
            this.Details = details;
        }

        public override string ToString()
        {
            string componentToPrint = this.Name + " " + this.Price + " " + this.Details;
            return componentToPrint;
        }
    }
}
