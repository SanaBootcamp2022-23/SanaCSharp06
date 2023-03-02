using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Student : Human
    {
        protected string Kurs;
        protected string Group;
        protected string Fakultet;
        protected string Vnz;

        public Student()
        {
            Name = "Name";
            Surname = "Surname";
            Birthday = "Birthday";
            Kurs = "Kurs";
            Group = "Group";
            Fakultet = "Fakultet";
            Vnz = "Vnz";
        }

        public Student(string name, string surname, string birthday, string kurs, string group, string fakultet, string vnz)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Kurs = kurs;
            Group = group;
            Fakultet = fakultet;
            Vnz = vnz;
        }

        public Student(Student obj)
        {
            Name = obj.Name;
            Surname = obj.Surname;
            Birthday = obj.Birthday;
            Kurs = obj.Kurs;
            Group = obj.Group;
            Fakultet = obj.Fakultet;
            Vnz = obj.Vnz;
        }

        public string GetKurs()
        {
            return Kurs;
        }

        public string GetGroup()
        {
            return Group;
        }

        public string GetFakultet()
        {
            return Fakultet;
        }

        public string GetVnz()
        {
            return Vnz;
        }

        public void SetKurs(string kurs)
        {
            Kurs = kurs;
        }

        public void SetGroup(string group)
        {
            Group = group;
        }

        public void SetFakultet(string fakultet)
        {
            Fakultet = fakultet;
        }

        public void SetVnz(string vnz)
        {
            Vnz = vnz;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Студент.");
            Console.WriteLine($" Курс: {Kurs}");
            Console.WriteLine($" Група: {Group}");
            Console.WriteLine($" Факультет: {Vnz}");
        }
    }
}
