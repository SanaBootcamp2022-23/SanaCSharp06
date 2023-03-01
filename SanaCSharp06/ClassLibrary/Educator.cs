using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Educator : Human
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string University { get; set; }

        public Educator(string name, string lastName, DateTime dateOfBirth, string position, string department, string university) : base(name, lastName, dateOfBirth)
        {
            Position = position;
            Department = department;
            University = university;
        }
        public Educator(string name, string lastName, DateTime dateOfBirth) : base(name, lastName, dateOfBirth)
        {
            Position = "Teacher";
            Department = "Teacher host";
            University = "University";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {Position}\nDepartment: {Department}\nUniversity: {University}");
        }
    }
}
