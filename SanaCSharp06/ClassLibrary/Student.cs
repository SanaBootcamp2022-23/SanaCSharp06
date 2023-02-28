using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Human
    {
        protected int year;
        protected string groupCode;
        protected string faculty;
        protected string university;
        public Student()
        {
            year = 1;
            groupCode= string.Empty;
            faculty = string.Empty;
            university = string.Empty;
        }
        public Student(string name, string surname, DateOnly birthdayDate, int year, string groupCode, string faculty, string university)
            :base(name, surname, birthdayDate)
        {
            this.year = year;
            this.groupCode = groupCode;
            this.faculty= faculty;
            this.university= university;
        }
        public Student(int year, string groupCode, string faculty, string university)
        {
            this.year = year;
            this.groupCode = groupCode;
            this.faculty = faculty;
            this.university = university;
        }
        public int Year { set; get; }
        public string GroupCode { set; get;}
        public string Faculty { set; get;}
        public string University { set; get;}
        public override void ShowInfo()
        {
            Console.WriteLine("Student: ");
            Console.WriteLine($"  First name: {this.name}");
            Console.WriteLine($"  Last name: {this.surname}");
            Console.WriteLine($"  Date of birth: {this.birthdayDate}");
            Console.WriteLine($"  Year of studying: {this.year}");
            Console.WriteLine($"  Group code: {this.groupCode}");
            Console.WriteLine($"  Faculty: {this.faculty}");
            Console.WriteLine($"  University: {this.university}");
        }
    }
}
