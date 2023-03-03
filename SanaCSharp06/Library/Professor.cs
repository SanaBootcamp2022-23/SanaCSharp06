using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Professor : Human
    {
        private string _position;
        private string _department;
        private string _univName;

        public string Position { get { return _position; } set { _position = value; } }
        public string Department { get { return _department; } set { _department = value; } }
        public string UnivName { get { return _univName; } set { _univName = value; } }
        public Professor(string position, string department, string univName)
        {
            Position = position;
            Department = department;
            UnivName = univName;
        }

        public Professor(Professor Copy) {
            Position = Copy.Position;
            Department = Copy.Department;
            UnivName = Copy.UnivName;
        }
        public Professor(string name, string surname, DateOnly dateOfBirth, string position, string department, string univName) : base(name, surname, dateOfBirth)
        {
            Position = position;
            Department = department;
            UnivName = univName;
        }

        public Professor(Human human, string position, string department, string univName) :base(human)
        {
            Position = position;
            Department = department;
            UnivName = univName;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}\n Date of birth: {DateOfBirth}\n Position:{Position}\n" +
                $"Department: {Department}\n Univercity name: {UnivName}\n");
        }

    }
}
