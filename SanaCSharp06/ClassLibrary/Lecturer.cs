using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Lecturer : Person
    {
        //методи для встановлення та читання значень
        public string Position { get; set; }
        public string Department { get; set; }
        public string СollegeName { get; set; }

        //конструктори з параметрами
        public Lecturer(string name, string surname, string dateOfBirth, string position, string department, string сollegeName)
        : base(name, surname, dateOfBirth)
        {
            Position = position;
            Department = department;
            СollegeName = сollegeName;
        }
        public Lecturer(string name, string surname, string dateOfBirth, string department, string сollegeName)
        : base(name, surname, dateOfBirth)
        {
            Position = "Лектор";
            Department = department;
            СollegeName = сollegeName;
        }
        //віртуальний метод ShowInfo()
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада: {Position}");
            Console.WriteLine($"Кафедра: {Department}");
            Console.WriteLine($"Назва ВНЗ: {СollegeName}");
        }
    }
}
