using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student : Person
    {
        private short course;
        private string groupName;
        private string facultyName;
        private string universityName;

        public short Course
        {
            get { return course; }
            set
            {
                if (value >= 1 && value <= 6)
                    course = value;
            }
        }
        public string GroupName
        {
            get { return groupName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    groupName = value;
            }
        }
        public string FacultyName
        {
            get { return facultyName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    facultyName = value;
            }
        }
        public string UniversityName
        {
            get { return universityName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    universityName = value;
            }
        }

        public Student() { }
        public Student(string name, string surname, DateTime dateOfBirth, short course, string groupName, string facultyName, string universityName) : base(name, surname, dateOfBirth)
        {
            Course = course;
            GroupName = groupName;
            FacultyName = facultyName;
            UniversityName = universityName;
        }
        public Student(string name, string surname, short course, string groupName, string facultyName) : this(name, surname, new DateTime(), course, groupName, facultyName, "")
        { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course: {Course}\nGroup name: {GroupName}\nFaculty name: {FacultyName}\n" +
                $"University name: {UniversityName}");
        }
    }
}
