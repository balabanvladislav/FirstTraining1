using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTraining1
{
    class Student
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public string Speciality { get; set; }
        public Student(string Name, string Surname, int Age=19, string Speciality="TI")
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
            this.Speciality = Speciality;
        }
        public string GetInfo()
        {
            return $"{Surname} {Name}, {Age} years, {Speciality} Speciality";
        }
    }
}
