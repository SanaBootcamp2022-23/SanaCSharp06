using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Professor : Human
    {
        protected string position;
        protected string department;
        protected string university;
        public Professor()
        {
            position = string.Empty;
            department = string.Empty;
            university= string.Empty;
        }
        public Professor(string name, string surname, DateOnly birthdayDate, string position, string department, string university)
            :base(name, surname, birthdayDate)
        {
            this.position = position;
            this.department = department;
            this.university= university;
        }
        public Professor(string position, string department, string university)
        {
            this.position = position;
            this.department = department;
            this.university = university;
        }
        public string Position { get; set; }
        public string Department { get; set; }
        public string University { get;set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Lecturer: ");
            Console.WriteLine($"  First name: {this.name}");
            Console.WriteLine($"  Last name: {this.surname}");
            Console.WriteLine($"  Date of birth: {this.birthdayDate}");
            Console.WriteLine($"  Position: {this.position}");
            Console.WriteLine($"  Department: {this.department}");
            Console.WriteLine($"  University: {this.university}");
        }
    }
}
