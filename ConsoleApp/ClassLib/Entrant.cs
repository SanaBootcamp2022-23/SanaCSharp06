using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLib
{
    public class Entrant : Person
    {
        public int ScoreZNO { get; set; }
        public int ScoreCertificate { get; set; }
        public string School { get; set; }
        public Entrant(string firstName, string lastName, string birthDate, 
            int scoreZNO, int scoreCertificate, string school) : base(firstName, lastName, birthDate)
        {
            ScoreZNO = scoreZNO;
            ScoreCertificate = scoreCertificate;
            School = school;
        }

        public Entrant()
        {

        }

        public Entrant(string firstName, string lastName, int scoreCertificate, string school) : base(firstName, lastName)
        {
            ScoreCertificate = scoreCertificate;
            School = school;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {FirstName}\nПрізвище: {LastName}" +
                $"\nКількість балів сертифікатів ЗНО: {ScoreZNO}" +
                $"\nКількість балів атестату: {ScoreCertificate}" +
                $"\nНазва навчального закладу: {School}\n");
        }
    }
}
