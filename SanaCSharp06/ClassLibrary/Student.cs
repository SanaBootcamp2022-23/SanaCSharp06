using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Person
    {
        protected string _course { get; set; }
        protected string _group { get; set; }
        protected string _faculty { get; set; }
        protected string _university { get; set; }
        public Student() { }
        public Student(string name, string surname, DateTime dateTime, string course, string group, string faculty, string university) : base(name, surname, dateTime)
        {
            _course = course;
            _group = group;
            _faculty = faculty;
            _university = university;
        }
        
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Курс: {_course}");
            Console.WriteLine($"Группа: {_group}");
            Console.WriteLine($"Факультет: {_faculty}");
            Console.WriteLine($"ВНЗ: {_university}");
        }
    }
}
