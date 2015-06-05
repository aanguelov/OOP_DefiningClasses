using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Laptop toshiba = new Laptop("Satellite", 1500.00m);

            Laptop lenovo = new Laptop("Lenovo Yoga 2 Pro", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 
                "13.3 (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", new Battery("Li-Ion", 4, 2550, 4.5), 2259.00m);

            Laptop sony = new Laptop("Vaio", "Sony", "Intel® Core™ i3 4005U", 4, "Intel HD Graphics 4400",
                                        "500 GB 5400 rpm HDD", "Glare TRILUMINOS 15.5' 1366 x 768 LCD LED",
                                        new Battery("Li Ion", 4, 3500, 5), 9999.00m);


            Laptop[] laptops = new Laptop[] { toshiba, lenovo, sony };
            foreach (var laptop in laptops)
            {
                Console.WriteLine(laptop);
                Console.WriteLine();
            }

        }
    }
}
