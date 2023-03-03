using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Student : Applicant
    {
        public int Course { get; set; }                 // курс у ВНЗ
        public string Group { get; set; }               // група у ВНЗ
        public string Faculty { get; set; }             // назва факультету, де навчається(-вся(-лась))
        public string NameOFUniversity { get; set; }    // назва ВНЗ
        public Student(string name, string surname, string birthday, double avgFinalExamScore, double avgCertificateScore, string nameOfGEI, int course, string group, string faculty, string nameOfUniversity) 
            : base(name, surname, birthday, avgFinalExamScore, avgCertificateScore, nameOfGEI)
        { 
            Course= course;
            Group= group;
            Faculty= faculty;
            NameOFUniversity= nameOfUniversity;
        }
        public Student(string name, string surname, string birthday, double avgFinalExamScore, double avgCertificateScore, string nameOfGEI, string group, string faculty, string nameOfUniversity) 
            : base(name, surname, birthday, avgFinalExamScore, avgCertificateScore, nameOfGEI)
        {
            Course = 0;
            Group = group;
            Faculty = faculty;
            NameOFUniversity = nameOfUniversity;
        }
        public virtual void ShowInfo()
        { 
            base.ShowInfo();
            Console.WriteLine($"Курс навчання: {Course}");
            Console.WriteLine($"Група:         {Group}");
            Console.WriteLine($"Факультет:     {Faculty}");
            Console.WriteLine($"Назва ВНЗ:     {NameOFUniversity}");
        }
    }
}
