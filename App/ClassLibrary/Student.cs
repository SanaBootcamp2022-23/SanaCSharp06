using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Person
    {
        protected int courseNum { get; set; }
        protected string groupNum { get; set; }
        protected string facultyName { get; set; }
        protected string universityName { get; set; }

        public Student(string firstName, string lastName, int  courseNum, string groupNum, string facultyName, string universityName) : base(firstName, lastName)
        {
            this.courseNum = courseNum;
            this.groupNum = groupNum;
            this.facultyName = facultyName;
            this.universityName = universityName;

        }
        public Student(string firstName, string lastName, string facultyName, string universityName) : base(firstName, lastName)
        {

            this.facultyName = facultyName;
            this.universityName = universityName;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($" Name: {this.firstName}");
            Console.WriteLine($" Surname: {this.lastName}");
            Console.WriteLine($" Birth date: {this.birthDate}");
            Console.WriteLine($" Studying year: {this.courseNum}");
            Console.WriteLine($" Group: {this.groupNum}");
            Console.WriteLine($" Faculty: {this.facultyName}");
            Console.WriteLine($" University: {this.universityName}");
            Console.WriteLine("----------------------------------");
        }
    }
}
