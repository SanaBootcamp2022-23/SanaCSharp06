using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Entrant : Human
    {
        protected double znoScore;
        protected double tabelScore;
        protected string schoolName;
        public Entrant()
        {
            znoScore= 0;
            tabelScore= 0;
            schoolName= string.Empty;
        }
        public Entrant(string name, string surname, DateOnly birthdayDate, double znoScore, double tabelScore, string schoolName)
            :base(name, surname, birthdayDate)
        {
            this.znoScore= znoScore;
            this.tabelScore= tabelScore;
            this.schoolName= schoolName;
        }
        public Entrant(double znoScore, double tabelScore, string schoolName)
        {
            this.znoScore = znoScore;
            this.tabelScore = tabelScore;
            this.schoolName = schoolName;
        }
        public double ZnoScore { get; set; }
        public double TabelScore { get; set; }
        public string SchoolName { get; set;}
        public override void ShowInfo()
        {
            Console.WriteLine("Entrant: ");
            Console.WriteLine($"  First name: {this.name}");
            Console.WriteLine($"  Last name: {this.surname}");
            Console.WriteLine($"  Date of birth: {this.birthdayDate}");
            Console.WriteLine($"  Score of ZNO certificate: {this.znoScore}");
            Console.WriteLine($"  Score of table: {this.tabelScore}");
            Console.WriteLine($"  Name of school: {this.schoolName}");
        }
    }
}
