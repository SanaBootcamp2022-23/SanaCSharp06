using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Entrant : Person
    {
        protected double SumZNOResult;
        protected double SumEducationDocumentResult;
        protected string NameOfSchool;

        public Entrant(string name, string surname, DateTime dateofbirth, double
       sumZNOresult, double sumEducationDocumentResult, string nameOfSchool) : this(name,surname,dateofbirth, sumZNOresult, sumEducationDocumentResult)
        {
            NameOfSchool = nameOfSchool;
        }
        public Entrant(string name, string surname, DateTime dateofbirth, double
       sumZNOresult, double sumEducationDocumentResult) : base(name, surname, dateofbirth)
        {
            SumZNOResult = sumZNOresult;
            SumEducationDocumentResult = sumEducationDocumentResult;
            NameOfSchool = "School21";
        }

        public double SumZnoResultProperty
        {
            get { return SumZNOResult; }
            set { SumZNOResult = value; }
        }
        public double SumEducationDocumentResultProperty
        {
            get { return SumEducationDocumentResult; }
            set { SumEducationDocumentResult = value; }
        }
        public string NameOfSchoolProperty
        {
            get { return NameOfSchool; }
            set { NameOfSchool = value; }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Ім'я -> {Name} // прізвище -> {Surname} // дата народження -{DateOfBirth} // кількість балів сертифікатів ЗНО -> {SumZNOResult} // кількість балів за документ про освіту ->{SumEducationDocumentResult} // назва загальноосвітнього навчальногозакладу->{NameOfSchool}");
        }
    }
}
