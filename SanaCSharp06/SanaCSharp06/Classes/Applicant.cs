using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06.Classes
{
    public class Applicant : Person
    {
        public List<ZNOResult> ZNOResults { get; set; }

        public float CertificateMark { get; set; }
        public string SecondarySchoolName { get; set; }

        public Applicant(string firstName, string lastName, DateTime birthDate, List<ZNOResult> znoPoints,
            float certificateMark, string secondarySchoolName) : base(firstName, lastName, birthDate)
        {
            ZNOResults = znoPoints;
            CertificateMark = certificateMark;
            SecondarySchoolName = secondarySchoolName;
        }
        public Applicant(string firstName, string lastName, DateTime birthDate,
            float certificateMark) : base(firstName, lastName, birthDate)
        {
            CertificateMark = certificateMark;
            ZNOResults = new List<ZNOResult>();
            SecondarySchoolName = "Unknown";
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {FirstName},\nLast name: {LastName},\nBirthday: {BirthDate},\n" +
                $"Certificate mark: {CertificateMark},\nSecondary school name: {SecondarySchoolName}");

            if (ZNOResults.Count > 0) 
            {
                Console.WriteLine("ZNO results:");
                foreach (var result in ZNOResults)
                {
                    Console.WriteLine($"{result.Subject} - {result.Points} points");
                }
            }
            else
            {
                Console.WriteLine("No available ZNO results");
            }
            Console.WriteLine();
        }
    }
}
