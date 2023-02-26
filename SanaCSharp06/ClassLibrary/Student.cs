using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student:People
    {
        protected int _Course;
        protected string _GroupName;
        protected string _Faculty;
        protected string _NameOfUniversity;


        public Student(string firstName, string secondName, DateTime bdate, int course, string groupName, string faculty, string nameOfUniversity):base(firstName, secondName, bdate)
        {
            _Course = course;
            _GroupName = groupName;
            _Faculty = faculty;
            _NameOfUniversity = nameOfUniversity;
        }

        public Student(string firstName, string secondName, int day, int month, int year, int course, string groupName, string faculty, string nameOfUniversity) : base(firstName, secondName, day, month, year)
        {
            _Course = course;
            _GroupName = groupName;
            _Faculty = faculty;
            _NameOfUniversity = nameOfUniversity;
        }

        public string NameOfUniversity { 
            get { return _NameOfUniversity; }
            set { _NameOfUniversity = value;}
        }

        public int Course
        {
            get { return _Course; }
            set { _Course = value;}
        }

        public string Faculty
        {
            set { _Faculty = value; }
            get { return _Faculty; }
        }

        public string GroupName
        {
            set { _GroupName = value;}
            get { return _GroupName; }
        }

        public override string ShowInfo()
        {
            return base.ShowInfo() + $" {_NameOfUniversity} {_Faculty} {_Course} {_GroupName}";
        }
    }
}
