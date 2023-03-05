using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        //методи для встановлення та читання значень
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }

        //конструктори з параметрами
        public Person(string name, string surname, string dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = "01.01.1970";
        }

        //віртуальний метод ShowInfo()
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Прізвище: {Surname}");
            Console.WriteLine($"Дата народження: {DateOfBirth}");
        }
    }
}
