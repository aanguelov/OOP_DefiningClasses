using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftwareUniversityLearningSystem
{
    class Student : Person
    {
        private int studentNumber;

        private int averageGrade;

        public Student(string firstName, string lastName, int age, int studentNumber, int averageGrade) 
            : base(firstName, lastName, age)
        {
            this.AverageGrade = averageGrade;
            this.StudentNumber = studentNumber;
        }

        public int StudentNumber { get; set; }

        public int AverageGrade { get; set; }
    }
}
