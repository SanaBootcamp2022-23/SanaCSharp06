using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student : Applicant
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string HigherEducation { get; set; }

        public Student(int course, string group, string faculty,
        string higherEducation, int znoScore, float educationScore, string name, string secondName)
            : base(znoScore, educationScore, name, secondName)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            HigherEducation = higherEducation;
        }

        public Student(int course, string group, int znoScore, float educationScore, string name, string secondName) 
            : base (znoScore, educationScore, name, secondName)
        {
            Course = course;
            Group = group;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Group: {Group}");
            Console.WriteLine($"Faculty: {Faculty}");
            Console.WriteLine($"Higher Education: {HigherEducation}");
        }
    }
}
