using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Applicant : Person
    {
        public int ZnoPoints { get; set; }
        public int AvaragePoints { get; set; }
        public string School { get; set; }
        public Applicant()
        {
            ZnoPoints = 200;
            AvaragePoints = 12;
            School = "Symonivska School";
    }
        public Applicant(DateTime dateOfBirthday, string name, string surname, int znoPoints, int avaragePoints, string school)
            : base(dateOfBirthday, name, surname)
        {
            ZnoPoints = znoPoints;
            AvaragePoints = avaragePoints;
            School = school;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Applicant:");
            Console.WriteLine($"Name:{Name} Surname: {Surname} " +
                $"Date of bitrthday: {DateOfBirthday.Day}/{DateOfBirthday.Month}/{DateOfBirthday.Year} ZnoPoints: {ZnoPoints} AvaragePoints: {AvaragePoints} " +
                $"School: {School}");
        }

    }
}
