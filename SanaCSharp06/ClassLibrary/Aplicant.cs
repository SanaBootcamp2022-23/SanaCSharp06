using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Aplicant : Human
    {
        public int ZnoScore { get; set; }
        public double EduCertificateScore { get; set; }
        public string NameOfSchool { get; set; }

        public Aplicant(string name, string lastName, DateTime dateOfBirth, int znoScore, double eduCertificateScore, string nameOfSchool) : base(name, lastName, dateOfBirth)
        {
            ZnoScore= znoScore;
            EduCertificateScore= eduCertificateScore;
            NameOfSchool= nameOfSchool;
        }
        public Aplicant(string name, string lastName, DateTime dateOfBirth) : base(name, lastName, dateOfBirth)
        {
            ZnoScore = 600;
            EduCertificateScore = 10.2;
            NameOfSchool = "School 5";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Zno score: {ZnoScore}\nEducation certificate score: {EduCertificateScore}\nName of school: {NameOfSchool}");
        }
    }
}
