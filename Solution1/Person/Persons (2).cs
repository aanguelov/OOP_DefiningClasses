using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Persons
    {
        static void Main(string[] args)
        {
            var myFirstPerson = new Person(30, "Max", "MadMax@furyRoad.au");
            Console.WriteLine(myFirstPerson);

            var mySecondPerson = new Person(12, "Bobby");
            Console.WriteLine(mySecondPerson);
        }
    }
}
