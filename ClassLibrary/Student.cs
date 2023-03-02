using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Person
    {
        private int Course { get; set; } = 2;
        private string Group { get; set; } = "DA-12";
        private string Faculty { get; set; } = "IASA";
        private string University { get; set; } = "KPI";

        public Student()
        {

        }
        public Student(string dateOfBirthday, string name, string surname, int course, string group, string faculty, string university)
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
                $"Date of bitrthday: {DateOfBirthday} Course: {Course} Group: {Group} " +
                $"Faculty: {Faculty} University: {University}");
        }

    }
}
