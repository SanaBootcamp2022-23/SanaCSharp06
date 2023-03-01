using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass
{
    public class Student : Person
    {
        public int Course { get; set; }
        public string Group { get; set; }

        public string Faculty { get; set; }

        public string University { get; set; }
        public Student(string firstName, string lastName, DateTime dateOfBirth, int course, string group, string faculty, string university)
        : base(firstName, lastName, dateOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
       
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course: {Course}\nGroup: {Group}\nFaculty: {Faculty}\nUniversity: {University}");
        }
    }
}

