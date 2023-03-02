using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Teacher : Human
    {
        private string post;
        private string cathedra;
        private string nameOfHigherEducationInstitution;

        public Teacher(string name, string surname, DateTime dateOfBirth, string post) : base(name, surname, dateOfBirth) => SetPost(post);
        public Teacher(string name, string surname, DateTime dateOfBirth, string post, string cathedra, string nameOfInstitutionHigherEducation) : base(name, surname, dateOfBirth)
        {
            SetPost(post);
            SetCathedra(cathedra);
            SetNameOfHigherEducationInstitution(nameOfInstitutionHigherEducation);
        }

        public void SetPost(string value) => post = value;
        public string GetPost() => post;
        public void SetCathedra(string value) => cathedra = value;
        public string GetCathedra() => cathedra;
        public void SetNameOfHigherEducationInstitution(string value) => nameOfHigherEducationInstitution = value;
        public string GetNameOfHigherEducationInstitution() => nameOfHigherEducationInstitution;
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада: {GetPost()}");
            Console.WriteLine($"Кафедра: {GetCathedra()}");
            Console.WriteLine($"Вищий навчальний заклад: {GetNameOfHigherEducationInstitution()}");
        }
    }
}
