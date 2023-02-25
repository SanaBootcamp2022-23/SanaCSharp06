using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp6
{
    public class Applicant:Person
    {
        public string Mark { get; set; }
        public string DocumentOfEducationMark { get; set; }
        public string NameOfShcool { get; set; }

        public Applicant (string name,string surName,string birth,string mark, string documentOfEducationMark, string nameOfShcool):base(name,surName,birth)
        {
            Mark=mark;
            DocumentOfEducationMark=documentOfEducationMark;
            NameOfShcool=nameOfShcool;
        }
        public Applicant(string name, string surName, string birth, string mark, string documentOfEducationMark) : base(name, surName, birth)
        {
            Mark = mark;
            DocumentOfEducationMark = documentOfEducationMark;
            
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Кількість балів сертифікатів ЗНО: {Mark};\nКількість балів за документ про освіту: {DocumentOfEducationMark};";
            info += NameOfShcool == "" ? "" : $"\nНазва загальноосвітнього навчального закладу: {NameOfShcool}";
            Console.WriteLine(info);
        }
    }
}
