using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student : Person
    {
        public short Course
        {
            get { return Course; }
            set
            {
                if (value >= 1 && value <= 6)
                    Course = value;
            }
        }
        public string GroupName
        {
            get { return GroupName; }
            set
            {
                if (!String.IsNullOrEmpty(GroupName))
                    GroupName = value;
            }
        }
        public string FacultyName
        {
            get { return FacultyName; }
            set
            {
                if (!String.IsNullOrEmpty(FacultyName))
                    FacultyName = value;
            }
        }
        public string UniversityName
        {
            get { return UniversityName; }
            set
            {
                if (!String.IsNullOrEmpty(UniversityName))
                    UniversityName = value;
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
