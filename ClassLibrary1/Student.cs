using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student : Person
    {
        public int Course { get; set; }
        public string Group { get; set; }   
        public string Faculty { get; set; }
        public string UniversityName { get; set; }
        public Student() : base()
        {
            Course = 0;
            Group = "None";
            Faculty = "None";
            UniversityName = "None";
        }
       public Student(string  name, string lastName, Date birthDate, int course,
           string group, string faculty, string universityName) : base(name, lastName, birthDate) 
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            UniversityName = universityName;
        }
        public Student(string name, string lastName, Date birthDate, int course):base (name, lastName,birthDate)
        {
            Course = course;
            Group = "None";
            Faculty = "None";    
        }
        public override void ShowInfo()
        {
           base.ShowInfo();
            Console.WriteLine($"Курс: {Course}\n" +
                $"Група: {Group}\n" +
                $"Факультет: {Faculty}\n" +
                $"Університет: {UniversityName}");
        }
    }
}
