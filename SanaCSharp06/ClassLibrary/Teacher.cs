using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        protected string _position;
        protected string _chair;
        protected string _university;

        public string Position
        {
            set
            {
                if (value != "")
                {
                    _position = value;
                }
            }
            get { return _position; }
        }
        public string Chair
        {
            set
            {
                if (value != "")
                {
                    _chair = value;
                }
            }
            get { return _chair; }
        }
        public string University
        {
            set
            {
                if (value != "")
                {
                    _university = value;
                }
            }
            get { return _university; }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position : {Position}");
            Console.WriteLine($"Chair : {Chair}");
            Console.WriteLine($"University : {University}");
        }
        public Teacher() { }
        public Teacher(string position, string chair, string university)
        {
            Position = position;
            Chair = chair;
            University = university;
        }

        public Teacher(string position, string chair, string university, Person person)
        {
            Position = position;
            Chair = chair;
            University = university;
            FirstName= person.FirstName;
            LastName=person.LastName;
            DateBirth= person.DateBirth;
        }
        public Teacher(Teacher teacher)
        {
            Position = teacher.Position;
            Chair = teacher.Chair;
            University = teacher.University;
            FirstName = teacher.FirstName;
            LastName = teacher.LastName;
            DateBirth = teacher.DateBirth;
        }

    }
}
