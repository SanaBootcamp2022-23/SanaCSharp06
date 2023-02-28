using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Prakt
{
    public class Student : Human
    {
        protected int courseNumber;
        public int CourseNumber
        {
            get { return courseNumber; }
            set { if (value >= 0 && value < 5) courseNumber = value; }
        }

        protected string groupName;
        public string GroupName
        {
            get { return groupName; }
            set { if (value != null) groupName = value; }
        }

        protected string faculty;
        public string Faculty
        {
            get { return faculty; }
            set { if(value != null) faculty = value; }
        }

        protected string nameOfUniversity;
        public string NameOfUniversity
        {
            get { return nameOfUniversity;}
            set{ if (value != null) nameOfUniversity = value; }
        }

        public Student (string name, string surname, DateTime birthday, int course, string group, string faculty, string university) 
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirthday = birthday;
            this.courseNumber = course;
            this.groupName = group;
            this.faculty = faculty;
            this.nameOfUniversity = university;
        }
        public Student (int course, string group, string faculty, string university)
        {
            this.courseNumber = course;
            this.groupName = group;
            this.faculty = faculty;
            this.nameOfUniversity = university;
        }
        public Student (Human person, int course, string group, string faculty, string university) : this(person.Name, person.Surname, person.DateOfBirthday, course, group, faculty, university) { }


        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course: {this.courseNumber}");
            Console.WriteLine($"Group: {this.groupName}");
            Console.WriteLine($"Faculty: {this.faculty}");
            Console.WriteLine($"University: {this.nameOfUniversity}");
            Console.WriteLine();

        }


    }
}
