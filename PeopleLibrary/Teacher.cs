using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLibrary
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Departament { get; set; }
        public string University { get; set; }
        public Teacher(string firstName, string lastName, DateTime birthDate, string position, string departament,
            string university)
            : base(firstName, lastName, birthDate)
        {
            Position = position;
            Departament = departament;
            University = university;
        }
        public Teacher(Person person, string position, string departament,
            string university)
            : base(person.FirstName, person.LastName, person.BirthDate)
        {
            Position = position;
            Departament = departament;
            University = university;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, BirthDate: {BirthDate.ToString("dd'-'MM'-'yyyy")}," +
                $" Position: {Position}, Departament: {Departament}, University: {University}");
        }
    }
}
