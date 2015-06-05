using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftwareUniversityLearningSystem
{
    class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, int age, int studentNumber, int averageGrade) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {

        }
    }
}
