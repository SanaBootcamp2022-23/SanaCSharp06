using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06_ClassLibrary
{
    public enum UniversityPosEnum
    {
        Assisstant,
        Lecturer,
        SeniorLecturer,
        Dean,
        Docent,
        Professor,
        HeadOfDepartment,
        Prorector,
        Rector
    }

    public class Teacher : Person
    {
        public string UniversityName { get; set; }
        public string Department { get; set; }
        public UniversityPosEnum Position { get; set; } = UniversityPosEnum.Assisstant;


        public Teacher(string firstName, string lastName, DateTime birthDate, string universityName, string department)
            : base(firstName, lastName, birthDate)
        {
            UniversityName = universityName;
            Department = department;
        }

        public Teacher(string firstName, string lastName, DateTime birthDate, string universityName, string department, UniversityPosEnum position) :
            this(firstName, lastName, birthDate, universityName, department)
        {
            Position = position;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine($"University name: {UniversityName}");
            Console.WriteLine($"University department: {Department}");
            Console.WriteLine($"University position: {Position}");
        }
    }
}
