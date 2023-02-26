using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Applicant:Person
    {
        public double ZNOPoints { get; set; }
        public double СertificatePoints { get; set; }
        public string SchoolName { get; set; }
        public Applicant()
        {
            ZNOPoints = 0;
            СertificatePoints = 0;
            SchoolName = String.Empty;
        }
        public Applicant(string Name, string SurName, double CertificatePoints, string SchoolName) : base(Name, SurName)
        {
            ZNOPoints = 0;
            this.СertificatePoints = СertificatePoints;
            this.SchoolName = SchoolName;
        }
        public Applicant(string Name, string SurName, DateTime Birthday, double ZNOPoints, double CertificatePoints, string SchoolName) : base(Name, SurName, Birthday)
        {
            this.ZNOPoints = ZNOPoints;
            this.СertificatePoints = CertificatePoints;
            this.SchoolName = SchoolName;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Points of ZNO: {ZNOPoints}\nPoints of School certificates: {СertificatePoints}\nName of school: {SchoolName}");
        }
    }
}
