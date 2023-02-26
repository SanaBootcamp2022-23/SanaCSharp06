using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06.Classes
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string UniversityName { get; set; }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, string position, string department,
            string universityName) : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Department = department;
            UniversityName = universityName;
        }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, string position,
            string universityName) : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            UniversityName = universityName;
            Department = "Unknown";
        }

        public override void ShowInfo()
        {

            Console.WriteLine($"Name: {FirstName},\nLast name: {LastName},\nBirthday: {BirthDate},\n" +
                $"Position: {Position},\nDepartment: {Department},\nUniversityName: {UniversityName}");
            Console.WriteLine();
        }
    }
}
