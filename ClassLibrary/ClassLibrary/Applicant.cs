using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Applicant : Person
    {
        private int numberPointsZNO = 100;
        private int numberPointsDocumentEducation = 100;
        private string schoolName = "ЗОШ";
        public int NumberPointsZNO { get=>numberPointsZNO;
            set {
                if (value > 0)
                    numberPointsZNO = value;
            } }
        public int NumberPointsDocumentEducation { get=>numberPointsDocumentEducation;
            set {
                if (value > 0)
                    numberPointsDocumentEducation = value;
            } }
        public string SchoolName { get => schoolName;
            set
            {
                if (value.Length >= 3)
                    schoolName = value;
            }
        }

        public Applicant(string FirstName, string LastName, string DateOfBirth, int NumberPointsZNO, int NumberPointsDocumentEducation, string SchoolName)
            :base(FirstName, LastName, DateOfBirth)
        {
            this.NumberPointsZNO = NumberPointsZNO;
            this.NumberPointsDocumentEducation = NumberPointsDocumentEducation;
            this.SchoolName = SchoolName;
        }
        public Applicant(string FirstName, string LastName, int NumberPointsZNO, int NumberPointsDocumentEducation)
             :base(FirstName, LastName)
        {
            this.NumberPointsZNO = NumberPointsZNO;
            this.NumberPointsDocumentEducation = NumberPointsDocumentEducation;
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} \nКількість балів ЗНО: {NumberPointsZNO} \nКількість балів за документ про освіту: {NumberPointsDocumentEducation}" +
                $"\nНазва загальноосвітнього навчального закладу: {SchoolName}";
        }
    }
}
