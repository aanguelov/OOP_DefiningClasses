using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PC_Catalog
{
    class PC_Catalog
    {
        static void Main(string[] args)
        {
            List<Computer> catalog = new List<Computer>();
            List<Component> components = new List<Component>();
            Component monitor = new Component("Samsung", 150);
            components.Add(monitor);
            Component mouse = new Component("Canyon", 20);
            components.Add(mouse);
            Component hdd = new Component("Corsair", 60, "SSD");
            components.Add(hdd);
            Computer pc1 = new Computer("MyHomePC", components);
            catalog.Add(pc1);

            List<Component> components1 = new List<Component>();
            components1.Add(new Component("Motherboard", 20));
            components1.Add(new Component("CPU", 120.45m));
            components1.Add(new Component("RAM", 45.50m, "8 GB"));
            Computer pc2 = new Computer("MyLaptop", components1);
            catalog.Add(pc2);

            List<Component> components2 = new List<Component>();
            components2.Add(new Component("DVD", 15.99m));
            components2.Add(new Component("GPU", 255.1m));
            Computer pc3 = new Computer("WorkStation", components2);
            catalog.Add(pc3);

            var sortedByPrize = catalog.OrderBy(c => c.Price).ToList();

            foreach (var pc in sortedByPrize)
            {
                Console.WriteLine(pc);
                Console.WriteLine();
            }

        }
    }
}
