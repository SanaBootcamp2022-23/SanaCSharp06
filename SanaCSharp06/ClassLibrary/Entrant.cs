using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Entrant : Person
    {
        //методи для встановлення та читання значень
        public double ScoreOfZNO { get; set; }
        public double EducationScores { get; set; }
        public string School { get; set; }

        //конструктори з параметрами
        public Entrant(string name, string surname, string dateOfBirth, double scoreOfZNO, double educationScore,
         string school)
        : base(name, surname, dateOfBirth)

        {
            ScoreOfZNO = scoreOfZNO;
            EducationScores = educationScore;
            School = school;
        }

        public Entrant(string name, string surname, string dateOfBirth, double educationScore,
         string school)
     : base(name, surname, dateOfBirth)
        {
            ScoreOfZNO = 100;
            EducationScores = educationScore;
            School = school;
        }

        //віртуальний метод ShowInfo()
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Бал сертифікату ЗНО: {ScoreOfZNO}");
            Console.WriteLine($"Середній бал атестату: {EducationScores}");
            Console.WriteLine($"Назва загальноосвітнього навчального закладу: {School}");
        }
    }
}
