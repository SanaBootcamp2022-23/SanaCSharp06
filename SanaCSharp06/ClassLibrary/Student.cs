using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student:Applicant
    {
        public string Course { get; set; }
        public string Faculty { get; set; }
        public string Group { get; set; }
        public string HigherEducationInstitution { get; set; }

        public Student(Person person , Applicant applicant , Student student)
            : base(person, applicant) 
        {
            Course= student.Course;
            Faculty= student.Faculty;
            Group= student.Group;
            HigherEducationInstitution= student.HigherEducationInstitution;
        
        }
        public Student(Person person, Applicant applicant, string course , string faculty ,string group , string univer)
           : base(person, applicant)
        {
            Course = course;
            Faculty = faculty;
            Group = group;
            HigherEducationInstitution = univer;

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Навчаюсь на факултеті {Faculty} , на {Course} курсі , в групі {Group} , у {HigherEducationInstitution}");
        }
    }
}
