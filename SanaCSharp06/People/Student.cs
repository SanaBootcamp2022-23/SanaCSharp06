using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Student : Person
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string UniversityName { get; set; }
        public Student()
        {
            Course = 0;
            Group = String.Empty;
            Faculty = String.Empty;
            UniversityName = String.Empty;
        }
        public Student(string Name, string SurName, int Course, string UniversityName) : base(Name, SurName)
        {
            this.Course = Course;
            Group = String.Empty;
            Faculty = String.Empty;
            this.UniversityName = UniversityName;
        }
        public Student(string Name, string SurName, DateTime Birthday, int Course, string Group, string Faculty, string UniversityName) : base(Name, SurName, Birthday)
        {
            this.Course = Course;
            this.Group = Group;
            this.Faculty = Faculty;
            this.UniversityName = UniversityName;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course: {Course}\nGroup: {Group}\nFaculty: {Faculty}\nName of University: {UniversityName}");
        }
    }
}
