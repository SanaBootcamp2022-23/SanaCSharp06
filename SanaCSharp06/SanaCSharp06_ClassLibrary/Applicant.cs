using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06_ClassLibrary
{
    public class Applicant : Person
    {
        public double ETScore { get; set; }
        public double EducationDocScore { get; set; }
        public string? InstitutionName { get; set; }

        public Applicant(string firstName, string lastName, DateTime birthDate, double etScore, double educationDocScore) 
            : base(firstName, lastName, birthDate)
        {
            ETScore = etScore;
            EducationDocScore = educationDocScore;
        }

        public Applicant(string firstName, string lastName, DateTime birthDate, double etScore, double educationDocScore, string insitutionName) 
            : this(firstName, lastName, birthDate, etScore, educationDocScore)
        {
            InstitutionName = insitutionName;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine($"External Test score: {ETScore}");
            Console.WriteLine($"Education document score: {EducationDocScore}");
            Console.WriteLine($"General education istitution name: {((InstitutionName != null) ? InstitutionName : "unknown")}");
        }
    }
}
