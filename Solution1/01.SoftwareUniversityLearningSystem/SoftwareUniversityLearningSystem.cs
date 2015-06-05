using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftwareUniversityLearningSystem
{
    class SoftwareUniversityLearningSystem
    {
        static void Main(string[] args)
        {
            List<Person> allPersons = new List<Person>();
            Trainer trainer = new Trainer("Nencho", "Ilchev", 55);
            allPersons.Add(trainer);
            Student student = new Student("Ivan", "Ivanov", 20, 100234, 5);
            allPersons.Add(student);
            JuniorTrainer junior = new JuniorTrainer("Koi", "Toi", 40);
            allPersons.Add(junior);
            SeniorTrainor senior = new SeniorTrainor("Ko?", "Ne!", 26);
            allPersons.Add(senior);
            GraduateStudent graduate = new GraduateStudent("Gosho", "Goshev", 30, 100987, 4);
            allPersons.Add(graduate);
            CurrentStudent current = new CurrentStudent("Milka", "OtSvoge", 18, 100545, 6, "BlowJobs");
            allPersons.Add(current);
            DropoutStudent dropper = new DropoutStudent("Pesho", "Peshev", 25, 100888, 3, "Too much gandja");
            allPersons.Add(dropper);
            OnlineStudent online = new OnlineStudent("Koko", "Boichev", 22, 100636, 4, "Math");
            allPersons.Add(online);
            OnsiteStudent onsite = new OnsiteStudent("Novak", "Djokovic", 27, 100654, 6, "RollandGaros", 8);
            allPersons.Add(onsite);

            var currentStudents = allPersons
                .Where(p => p is CurrentStudent).Cast<CurrentStudent>();
            var sortedCurrentStudents = currentStudents
                .OrderBy(s => s.AverageGrade).ToList();

            foreach (var item in sortedCurrentStudents)
            {
                StringBuilder currentStudent = new StringBuilder();
                currentStudent.AppendLine(item.FirstName);
                currentStudent.AppendLine(item.LastName);
                currentStudent.AppendLine(item.Age.ToString());
                currentStudent.AppendLine(item.AverageGrade.ToString());
                currentStudent.AppendLine(item.CurrentCourse);
                currentStudent.AppendLine(item.StudentNumber.ToString());

                Console.WriteLine(currentStudent.ToString());
                Console.WriteLine();
            }
        }
    }
}
