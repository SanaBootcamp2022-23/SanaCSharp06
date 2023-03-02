using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Applicant : Person
    {
        public int ZnoPoints { get; set; } = 200;
        public int AvaragePoints { get; set; } = 12;
        public string School { get; set; } = "Symonivska School";
        public Applicant()
        {

        }
        public Applicant(string dateOfBirthday, string name, string surname, int znoPoints, int avaragePoints, string school)
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
                $"Date of bitrthday: {DateOfBirthday} ZnoPoints: {ZnoPoints} AvaragePoints: {AvaragePoints} " +
                $"School: {School}");
        }

    }
}
