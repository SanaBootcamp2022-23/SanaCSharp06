using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass
{
    public class Applicant : Person
    {
        public decimal ZnoPoint { get; set; }
        public decimal EducationPoint { get; set; }
        public string School { get; set; }

        public Applicant(string firstName, string lastName, DateTime dateOfBirth, decimal znoPoint, decimal educationPoint,
         string school)
        : base(firstName, lastName, dateOfBirth)

        {
            ZnoPoint = znoPoint;
            EducationPoint = educationPoint;
            School = school;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ZNO Score: {ZnoPoint}\nEducation Score: {EducationPoint}\nSchool: {School}");
        }
    }
}