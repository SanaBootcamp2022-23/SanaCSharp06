using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary
{
    public class Applicant : Person
    {    
        public float markZNO { get; set; }
        public float GPA { get; set; }
        string schoolname { get; set; }
        public Applicant(string firstname, string lastname,DateTime dateofbirth,float markZNO, float GPA, string schoolname):base(firstname, lastname,dateofbirth)
        {          
            this.markZNO = markZNO;          
            this.GPA = GPA;
            this.schoolname = schoolname;         
        }
        public Applicant(Person person, float markZNO, float gpa, string schoolname) :
                         this(person.firstname, person.lastname, person.dateofbirth, markZNO, gpa, schoolname)
        { }
        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nБали ЗНО: {markZNO}\nСередній бал {GPA}\nЗагально-освітній навчальний заклад: " + schoolname;
        }
    }
}