using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Human
    {
       
        public char CourseYear { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }

        
        public Student(string name,string lastName, DateTime dateOfBirth, char courseYear, string group, string faculty, string university) : base(name,lastName, dateOfBirth)
        {
            CourseYear = courseYear;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public Student(string name, string lastName, DateTime dateOfBirth) : base(name, lastName, dateOfBirth)
        {
            CourseYear = '1';
            Group = "sana-23";
            Faculty = "SanaCommerce";
            University = "ZDTU";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course year: {CourseYear}\nGroupe: {Group}\nFaculty: {Faculty}\nUniversity: {University}");
        }
    }
}
