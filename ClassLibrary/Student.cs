using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student:Entrant
    {
        protected int Course;
        protected string Group;
        protected string Faculty;
        protected string NameOfInstitution;

        public Student(string name, string surname, DateTime dateofbirthday, float
       sumZNOresult, float sumEducationDocumentResult, string nameOfSchool, int course, string
       group, string faculty, string nameOfInstitution) :this(name,surname,dateofbirthday,sumZNOresult,sumEducationDocumentResult,nameOfSchool,course,nameOfInstitution)
        {
            Group = group;
            Faculty = faculty;
        }

        public Student(string name, string surname, DateTime dateofbirthday, float
       sumZNOresult, float sumEducationDocumentResult, string nameOfSchool, int course, string
       nameOfInstitution) : base(name, surname, dateofbirthday, sumZNOresult, sumEducationDocumentResult, nameOfSchool)
        {
            NameOfInstitution = nameOfInstitution;
            Course = course;
            Group = "ІПЗ-21-5";
            Faculty = "ФІКТ";
            
        }

        public int CourseProperty
        {
            get { return Course; }
            set { Course = value; }
        }
        public string GroupProperty
        {
            get { return Group; }
            set { Group = value; }
        }
        public string FacultyProperty
        {
            get { return Faculty; }
            set { Faculty = value; }
        }
        public string NameOfInstitutionProperty
        {
            get { return NameOfInstitution; }
            set { NameOfInstitution = value; }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Ім'я -> {Name} // прізвище -> {Surname} // дата народження -{DateOfBirth} // кількість балів сертифікатів ЗНО -> {SumZNOResult} // кількість балівза документ про освіту ->{ SumEducationDocumentResult} // назва загальноосвітнього навчальногозакладу->{ NameOfSchool} // курс ->{Course} // група ->{Group} // факультет ->{Faculty} //вищий навчальний заклад->{ NameOfInstitution}\n");
        }

    }
}
