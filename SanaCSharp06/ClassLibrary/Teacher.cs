using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        protected string _position { get; set; }
        protected string _chair { get; set; }
        protected string _university { get; set; }
        public Teacher() { }
        public Teacher(string name, string surname, DateTime dateTime, string position, string chair, string university) : base(name, surname, dateTime)
        {
            _position = position;
            _chair = chair;
            _university = university;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада: {_position}");
            Console.WriteLine($"Кафедра: {_chair}");
            Console.WriteLine($"ВНЗ: {_university}");
        }
    }
}
