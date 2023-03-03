using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Teacher : Human
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string HigherEducation { get; set; }

        public Teacher(string position, string department, string higherEducation, string name, string secondName) : base(name, secondName)
        {
            Position = position;
            Department = department;
            HigherEducation = higherEducation;
        }

        public Teacher(string position, string department, string name, string secondName) : base(name, secondName)
        {
            Position = position;
            Department = department;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Higher Education: {HigherEducation}");
        }
    }
}
