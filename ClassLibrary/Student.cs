using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Person
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }

        public Student()
        {
            Course = 2;
            Group = "DA-12";
            Faculty = "IASA";
            University = "KPI";
        }
        public Student(DateTime dateOfBirthday, string name, string surname, int course, string group, string faculty, string university)
            : base(dateOfBirthday, name, surname)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public override void ShowInfo() 
        {
            Console.WriteLine("Student:");
            Console.WriteLine($"Name:{Name} Surname: {Surname} " +
                $"Date of bitrthday: {DateOfBirthday.Day}/{DateOfBirthday.Month}/{DateOfBirthday.Year} Course: {Course} Group: {Group} " +
                $"Faculty: {Faculty} University: {University}");
        }

    }
}
