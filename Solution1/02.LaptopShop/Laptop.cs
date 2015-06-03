using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Laptop
    {
        private string model;
        private string manifacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        public Laptop(string model, string manifacturer, string processor, int ram, string graphicsCard,
                        string hdd, string screen, Battery battery, decimal price) : this(model, price)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraficsCard = graphicsCard;
            this.HDD = hdd;
            this.Screen = screen;
            this.Battery = battery;
            this.Price = price;
        }

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, string processor, string screen, Battery battery, decimal price)
                        : this(model,price)
        {
            this.Processor = processor;
            this.Screen = screen;
            this.Battery = battery;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model name must not be empty!");
                }
                this.model = value;
            }
        }

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manifacturer name must not be empty!");
                }
                this.manifacturer = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Processor type must not be empty!");
                }
                this.processor = value;
            }
        }

        public int Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Ram size must not be negative!");
                }
                this.ram = value;
            }
        }

        public string GraficsCard
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("GraficsCard type must not be empty!");
                }
                this.graphicsCard = value;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("HDD type must not be empty");
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Screen type must not be empty!");
                }
                this.screen = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must not be negative!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            //return string.Format
            //    ("Laptop {0}, model {1}, processor {2}, ram {3} GB, graphics {4}, HDD {5}, screen {6}, battery {7}, price {8:F2} lv.",
            //    this.Manifacturer ?? "[no info]", this.Model ?? "[no info]", this.Processor ?? "[no info]",
            //    this.Ram, this.GraficsCard ?? "[no info]", this.HDD ?? "[no info]",
            //    this.Screen ?? "[no info]", this.Battery, this.Price);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Laptop: {0}", this.Manifacturer ?? "[no info]"));
            sb.AppendLine(string.Format("Model: {0}", this.Model ?? "[no info]"));
            sb.AppendLine(string.Format("Processor: {0}", this.Processor ?? "[no info]"));
            sb.AppendLine(string.Format("Ram: {0} GB", this.Ram.ToString() ?? "[no info]"));
            sb.AppendLine(string.Format("Graphics: {0}", this.GraficsCard ?? "[no info]"));
            sb.AppendLine(string.Format("HDD: {0}", this.HDD ?? "[no info]"));
            sb.AppendLine(string.Format("Screen: {0}", this.Screen ?? "[no info]"));
            sb.AppendLine(string.Format("Battery: {0}", this.Battery));
            sb.AppendLine(string.Format("Price: {0:F2} lv.", this.Price.ToString() ?? "[no info]"));
            return sb.ToString();
        }
    }
}
