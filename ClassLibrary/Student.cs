using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Applicant
    {
        public string groupname { get; set; }
        public int course { get; set; }
        
        public string university { get; set; }

        public string faculty { get; set; }

        public Student(string firstname, string lastname, DateTime dateofbirth, string university,
                       string faculty, int course,string groupname, string schoolname, float markzno, float gpa) 
                      :base(firstname,lastname, dateofbirth, markzno,gpa,schoolname) 
        { 
            this.groupname = groupname;                 
            this.faculty = faculty;
            this.course = course;
            this.university = university;
        }
        public Student(Person person, string university, string faculty, int course, string groupname, string schoolname,
                       float markzno, float gpa) : this(person.firstname, person.lastname, person.dateofbirth, university, faculty, course,
                       groupname, schoolname, markzno, gpa)
        { }
       
        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nУніверситет: {university} \nФакультет: {faculty} \nКурс: {course} \nГрупа:{groupname}";
        }
    }
}