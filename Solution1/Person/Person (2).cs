using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        private int age;
        private string name;
        private string email;

        public Person(int age, string name, string email)
        {
            this.Age = age;
            this.Name = name;
            this.Email = email;
        }

        public Person(int age, string name) : this(age, name, null)
        {
            //this.Age = age;
            //this.Name = name;
        }

        public int Age 
        
        {
            get 
            {
                return this.age; 
            }
            set 
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age must be between one and one hundred years");
                }
                this.age = value; 
            }
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public string Email 
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value != null && !value.Contains("@") )
                {
                    throw new ArgumentException("The email must not be empty and has to contain '@'!");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("This Person`s name is {0}, and he is {1} years old. His email is: '{2}'", 
                                    this.Name, this.Age, this.Email ?? "No email");
        }
        

    }
}
