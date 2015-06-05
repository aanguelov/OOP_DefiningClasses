using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PC_Catalog
{
    class Computer
    {
        private string name;
        private List<Component> components;

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

        public List<Component> Components 
        {
            get { return this.components; }
            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.components = value;
            }
        }

        public decimal Price 
        {
            get { return CalculateComputerPrice(this); } 
        }

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        private decimal CalculateComputerPrice(Computer computer)
        {
            var components = computer.Components;
            decimal price = 0;
            foreach (var component in components)
            {
                price += component.Price;
            }
            return price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Name: {0}", this.Name));
            foreach (var component in components)
            {
                sb.AppendLine(string.Format("Component: {0}, price: {1} BGN", component.Name, component.Price));
            }
            sb.AppendLine(string.Format("Total computer prize: {0} BGN", this.Price));
            return sb.ToString();
        }
    }
}
