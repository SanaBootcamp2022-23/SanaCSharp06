using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Entrant : Human
    {
        private int pointsZNO;
        private int pointsEducation;
        private string nameOfEducationalInstitution;

        public Entrant(string name, string surname, DateTime dateOfBirth, string nameOfEducationalInstitution)
            : base(name, surname, dateOfBirth) => SetNameOfEducationalInstitution(nameOfEducationalInstitution);

        public Entrant(string name, string surname, DateTime dateOfBirth, string nameOfEducationalInstitution, int pointsZNO, int pointsEducation)
            : base(name, surname, dateOfBirth)
        {
            SetNameOfEducationalInstitution(nameOfEducationalInstitution);
            SetPointsZNO(pointsZNO);
            SetPointsEducation(pointsEducation);
        }

        public void SetNameOfEducationalInstitution(string value) => nameOfEducationalInstitution = value;
        public string GetNameOfEducationalInstitution() => nameOfEducationalInstitution;
        public void SetPointsZNO(int value) => pointsZNO = value;
        public int GetPointsZNO() => pointsZNO;
        public void SetPointsEducation(int value) => pointsEducation = value;
        public int GetPointsEducation() => pointsEducation;
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Кiлькiсть балiв сертифiкатiв ЗНО: {GetPointsZNO()}");
            Console.WriteLine($"Кiлькiсть балiв за документ про освiту: {GetPointsEducation()}");
            Console.WriteLine($"Назва загальноосвiтнього навчального закладу: {GetNameOfEducationalInstitution()}");
        }
    }
}
