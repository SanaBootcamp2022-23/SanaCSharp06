using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLibrary
{
    public class Student : Entrant
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public Student(string firstName, string lastName, DateTime birthDate, float ZNOPoints, float schoolPoints,
            string schoolName, int course, string group, string faculty, string university)
            : base(firstName, lastName, birthDate, ZNOPoints, schoolPoints, schoolName)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public Student(Entrant entrant, int course, string group, string faculty, string university)
            : base(entrant.FirstName, entrant.LastName, entrant.BirthDate, entrant.ZNOPoints, entrant.SchoolPoints, entrant.SchoolName)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course: {Course}, Group: {Group}, Faculty: {Faculty}, University: {University}");
        }
    }
}
