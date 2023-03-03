using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Student : Person
    {
        int Course { get; set; }
        string Group { get; set; }
        string Faculty { get; set; }
        string University { get; set; }
        public Student(string firstName, string lastName, string birthDate,
            int course, string group, string faculty, string university) : base(firstName, lastName, birthDate)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }

        public Student()
        {
             
        }

        public Student(string firstName, string lastName, int course, string group, string faculty) :
            base(firstName,lastName)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course: {Course}\n" +
                $"Group: {Group}\n" +
                $"Faculty: {Faculty}\n" +
                $"University: {University}");
        }


    }
}
