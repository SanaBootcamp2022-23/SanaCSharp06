using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Human
    {
        private string _name;
        private string _surname;
        private DateOnly _dateOfBirth;

        public string Name { get { return _name; } set { _name = value; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public DateOnly DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        public Human() {
            Name= "Name";
            Surname = "Surname";
            DateOfBirth = new DateOnly(2003,12,2);
        }

        public Human(string name, string surname, DateOnly dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;

        }

        public Human(Human Copy)
        {
            Name = Copy.Name;
            Surname = Copy.Surname;
            DateOfBirth = Copy.DateOfBirth;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}\n Date of birth: {DateOfBirth}\n");
        }
    }
}
