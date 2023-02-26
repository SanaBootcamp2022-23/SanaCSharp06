using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Teacher : Person
    {
        public string JobTitle { get; set; }    
        public string Department { get; set; }
        public string UniversityName { get; set; }
        public Teacher() : base()
        {
            JobTitle = "None";
            Department = "None";
            UniversityName = "None";
        }
        public Teacher(string name, string lastName, Date birthDate, string jobTitle, string department, string universityName) : base(name, lastName, birthDate) 
        {
            JobTitle = jobTitle;
            Department = department;
            UniversityName = universityName;
        }
        public Teacher(string name, string lastName, Date birthDate, string jobTitle, string department) : base(name, lastName, birthDate)
        {
            JobTitle = jobTitle;
            Department = department;
            UniversityName = "None";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада: {JobTitle}\n" +
                $"Кафедра {Department}" +
                $"Назва Університету: {UniversityName}");
        }
    }
    
}
