using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06_ClassLibrary
{
    public class Student : Person
    {
        private sbyte _studyingYear;
        public string UniversityName { get; set; }
        public string Faculty { get; set; }
        public string Group { get; set; }

        public sbyte StudyingYear
        {
            get { return _studyingYear; }
            set { if (value <= 10) _studyingYear = value; }
        }

        public Student(string firstName, string lastName, DateTime birthDate, string universityName, string faculty, string group)
            : base(firstName, lastName, birthDate)
        {
            UniversityName = universityName;
            Faculty = faculty;
            Group = group;
        }

        public Student(string firstName, string lastName, DateTime birthDate, string universityName, string faculty, string group, sbyte studyingYear)
            : this(firstName, lastName, birthDate, universityName, faculty, group)
        {
                StudyingYear = studyingYear;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine($"University name: {UniversityName}");
            Console.WriteLine($"Faculty: {Faculty}");
            Console.WriteLine($"Group: {Group}");
            Console.WriteLine($"Year of university: {StudyingYear}");
        }
    }
}
