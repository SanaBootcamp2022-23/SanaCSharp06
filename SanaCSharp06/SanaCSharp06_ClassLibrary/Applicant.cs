using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06_ClassLibrary
{
    public class Applicant : Person
    {
        private double _etScore;
        public string InstitutionName { get; set; } = "unknown";
        private double _educationDocScore;

        public double ETScore
        {
            get { return _etScore; }
            set { if (value >= 0 && value <= 200) _etScore = value; }
        }

        public double EducationDocScore
        {
            get { return _educationDocScore; }
            set { if (value >= 1 && value <= 12) _educationDocScore = value; }
        }

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
            Console.WriteLine($"General education istitution name: {InstitutionName}");
        }
    }
}

