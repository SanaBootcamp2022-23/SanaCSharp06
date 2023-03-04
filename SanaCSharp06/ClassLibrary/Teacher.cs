using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
       

        public string Position { get; set; }    
        public string Department { get; set; }
        public string University { get; set; }

        public Teacher(string firstName, string lastName, DateTime date, string position, string department, string university) : base(firstName, lastName, date)
        {
            Position = position;    
            Department = department;
            University = university;
        }
        public override string ShowInfo()
        {
            return $"Class Teacher => {FirstName} {LastName} {Date.Year}-{Date.Month}-{Date.Day} {Position} {Department} {University}";
        }

    }
}
