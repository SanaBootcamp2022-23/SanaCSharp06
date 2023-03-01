using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string University { get; set; }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, string position, string department, string university)
            : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Department = department;
            University = university;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {Position}\nDepartment: {Department}\nUniversity: {University}");
        }
    }
}
