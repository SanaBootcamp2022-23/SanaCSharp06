using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }


        public Person(string name, string surname, string birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Person()
        {
            Name = "Валерій";
            Surname = "П'ясківський";
            BirthDate = "2002, 5, 10";
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {Name}\nПрізвище: {Surname}\n");
        }
    }
}
