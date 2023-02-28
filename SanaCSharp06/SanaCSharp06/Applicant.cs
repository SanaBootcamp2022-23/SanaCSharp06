using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06
{
    public class Applicant : Person
    {
        protected int ExamZnoPoints;
        protected int AverageAtestat;
        protected string SchoolName;
        public Applicant(string firstName, string lastName, string birthDate,
            int examZnoPoints, int averageAtestat, 
            string schoolName) : base(firstName, lastName, birthDate) 
        {
            ExamZnoPoints = examZnoPoints;
            AverageAtestat = averageAtestat;
            SchoolName = schoolName;
        }
    }
}
