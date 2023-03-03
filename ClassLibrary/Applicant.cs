using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Applicant : Person
    {
        public double AvgFinalExamScore { get; set; }    // середній бал ЗНО
        public double AvgCertificateScore { get; set; }  // середній бал атестату
        public string NameOfGEI { get; set; }            // назва загальноосвітнього навчального закладу (the name of the general educational institution)
        public Applicant(string name, string surname, string birthday, double avgFinalExamScore, double avgCertificateScore, string nameOfGEI) 
            : base(name, surname, birthday)
        {
            AvgFinalExamScore = avgFinalExamScore;
            AvgCertificateScore = avgCertificateScore;
            NameOfGEI = nameOfGEI;
        }
        public Applicant(string name, string surname, string birthday, double avgCertificateScore, string nameOfGEI) 
            : base(name, surname, birthday)
        {
            AvgFinalExamScore = 100;
            AvgCertificateScore = avgCertificateScore;
            NameOfGEI = nameOfGEI;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Середній бал ЗНО:            {AvgFinalExamScore}");
            Console.WriteLine($"Середній бал Атестату:       {AvgCertificateScore}");
            Console.WriteLine($"Назва загальноосвітнього НЗ: {NameOfGEI}");
        }
    }
}
