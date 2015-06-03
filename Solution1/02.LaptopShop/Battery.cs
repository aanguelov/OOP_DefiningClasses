using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class Battery
    {
        private string batteryType;
        private int batteryCells;
        private int batteryPower;
        private double batteryLife;

        public Battery(string batteryType, int batteryCells, int batteryPower, double batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryCells = batteryCells;
            this.BatteryPower = batteryPower;
            this.BatteryLife = batteryLife;
        }

        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("BatteryType type must not be empty!");
                }
                this.batteryType = value;
            }
        }

        public int BatteryCells
        {
            get
            {
                return this.batteryCells;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("BatteryCells must not be negative!");
                }
                this.batteryCells = value;
            }
        }

        public int BatteryPower
        {
            get
            {
                return this.batteryPower;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("BatteryPower must not be negative!");
                }
                this.batteryPower = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("BatteryLife must not be negative!");
                }
                this.batteryLife = value;
            }
        }

        public override string ToString()
        {
            //return string.Format("Type of battery: {0}, number of cells: {1}-cells, max power: {2} mAh, max life: {3} hours",
            //                        this.BatteryType ?? "no info on battery type", this.BatteryCells, 
            //                        this.BatteryPower, this.BatteryLife);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Type of battery: {0}", this.BatteryType ?? "[no info]"));
            sb.AppendLine(string.Format("Number of cells {0}-cells", this.BatteryCells.ToString() ?? "[no info]"));
            sb.AppendLine(string.Format("Max power: {0} mAh", this.BatteryPower.ToString() ?? "[no info]"));
            sb.AppendLine(string.Format("Max life: {0} hours", this.BatteryLife.ToString() ?? "[no info]"));
            return sb.ToString();
        }
    }
}
