using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftwareUniversityLearningSystem
{
    class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, int studentNumber, 
                                int averageGrade, string dropoutReason) 
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }
        
        public string DropoutReason { get; set; }

        public void Reapply()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Student {0} {1}", this.FirstName, this.LastName));
            sb.AppendLine(string.Format("Age {0}", this.Age));
            sb.AppendLine(string.Format("Student number {0}", this.StudentNumber));
            sb.AppendLine(string.Format("Average grade {0}", this.AverageGrade));
            sb.AppendLine(string.Format("Reason to drop out {0}", this.DropoutReason));
        }
    }
}
