using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftwareUniversityLearningSystem
{
    class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {

        }

        public static void CreateCourse(string economicsCourse)
        {
            Console.WriteLine("The {0} has been created.", economicsCourse);
        }
    }
}
