using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Student
    {
        public string HigherEducationInstitutionTeaching { get; set; } = null!;
        public string position { get; set; }
        public string departamnet { get; set; }

        public Teacher(Person person , Applicant applicant , Student student , Teacher teacher )
            :base(person,applicant,student) 
        {
            HigherEducationInstitutionTeaching = teacher.HigherEducationInstitutionTeaching;
            position = teacher.position;
            departamnet= teacher.departamnet;
        }
        public Teacher(Person person, Applicant applicant, Student student,string edc, string pos , string dep)
        :base(person,applicant,student)
        {
            HigherEducationInstitutionTeaching = edc;
            position = pos; 
            departamnet = dep;
        }
        public override sealed void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Я {position} працюю у {HigherEducationInstitutionTeaching}, на кафедрі {departamnet},");
        }
    }
}
