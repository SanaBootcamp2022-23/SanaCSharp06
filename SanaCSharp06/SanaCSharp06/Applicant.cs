using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06
{
    public class Applicant : Person
    {
        protected string schoolName;
        public int ExamZnoPoints { get; set; }
        public double AverageAtestat { get; set; }
        public string SchoolName
        {
            get { return schoolName; }
            set { if (schoolName != "") schoolName = value; }
        }
        public Applicant(string firstName, string lastName, string birthDate,
            int examZnoPoints, double averageAtestat, 
            string schoolName) : base(firstName, lastName, birthDate) 
        {
            ExamZnoPoints = examZnoPoints;
            AverageAtestat = averageAtestat;
            SchoolName = schoolName;
        }
        public Applicant(string firstName, string lastName, string birthDate,
            int examZnoPoints, double averageAtestat) : base(firstName, lastName, birthDate)
        {
            ExamZnoPoints = examZnoPoints;
            AverageAtestat = averageAtestat;
        }
        public override string GetFullInfo()
        {
            return $"\n{FirstName} {LastName} ({BirthDate}) Atestat: {AverageAtestat}, " +
                $"ZNO: {ExamZnoPoints} in {SchoolName}";
        }
    }
}
