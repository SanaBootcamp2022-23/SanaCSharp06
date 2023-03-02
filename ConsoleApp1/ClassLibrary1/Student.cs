using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student : Human
    {
        private int course;
        private string group;
        private string faculty;
        private string nameOfInstitutionHigherEducation;

        public Student(string name, string surname, DateTime dateOfBirth, string group) : base(name, surname, dateOfBirth) => SetGroup(group);
        public Student(string name, string surname, DateTime dateOfBirth, int course, string group, string faculty, string nameOfInstitutionHigherEducation) : base(name, surname, dateOfBirth)
        {
            SetCourse(course);
            SetGroup(group);
            SetFaculty(faculty);
            SetNameOfInstitutionHigherEducation(nameOfInstitutionHigherEducation);
        }

        public void SetCourse(int value) => course = value;
        public int GetCourse() => course;
        public void SetGroup(string value) => group = value;
        public string GetGroup() => group;
        public void SetFaculty(string value) => faculty = value;
        public string GetFaculty() => faculty;
        public void SetNameOfInstitutionHigherEducation(string value) => nameOfInstitutionHigherEducation = value;
        public string GetNameOfInstitutionHigherEducation() => nameOfInstitutionHigherEducation;
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Курс: {GetCourse()}");
            Console.WriteLine($"Група: {GetGroup()}");
            Console.WriteLine($"Факультет: {GetFaculty()}");
            Console.WriteLine($"Вищий навчальний заклад: {GetNameOfInstitutionHigherEducation()}");
        }
    }
}
