using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Lecturer : Student
    {
        public string Position { get; set; }            // посада
        public string Faculty { get; set; }             // факультет, де працює(-вав(ла))
        public string NameOfUniversity { get; set; }    // назва ВНЗ
        public Lecturer(string name, string surname, string birthday, double avgFinalExamScore, double avgCertificateScore, string nameOfGEI, int course, string group, string position, string faculty, string nameOfUniversity) 
            : base(name, surname, birthday, avgFinalExamScore, avgCertificateScore, nameOfGEI, course, group, faculty, nameOfUniversity)
        {
            Position= position;
            Faculty= faculty;
            NameOfUniversity= nameOfUniversity;
        }
        public Lecturer(string name, string surname, string birthday, double avgFinalExamScore, double avgCertificateScore, string nameOfGEI, int course, string group, string faculty, string nameOfUniversity)
            : base(name, surname, birthday, avgFinalExamScore, avgCertificateScore, nameOfGEI, course, group, faculty, nameOfUniversity)
        {
            Position = "викладач";
            Faculty = faculty;
            NameOfUniversity = nameOfUniversity;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада:    {Position}");
            Console.WriteLine($"Факульет:  {Faculty}");
            Console.WriteLine($"Назва ВНЗ: {NameOfUniversity}");
        }
    }
}
