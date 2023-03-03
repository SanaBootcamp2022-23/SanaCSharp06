using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Person
    {
        protected int _course;
        protected string _group;
        protected string _faculty;
        protected string _nameOfUni;

        public int Course {
            //5 курс магістр 
            set {
                if (value >= 1 && value <= 5)  {
                    _course = value;
                }
            }
            get { return _course; } 
        }
        public string Group { 
            set
            {
                if (value != "")
                    _group = value;
            }
            get { return _group;} 
        }
        public string Faculty {
            set
            {
                if (value != ""){
                    _faculty = value;
                }
            }            
            get { return _faculty;} 
        }
        public string NameOfUni
        {
            set
            {
                if (value != "")
                {
                    _nameOfUni = value;
                }
            }
            get { return _nameOfUni; }
        }

        public Student() { }
        public Student(int course, string group, string faculty, string nameOfUni)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            NameOfUni = nameOfUni;
        }
        public Student(int course, string group, string faculty, string nameOfUni, Person person)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            NameOfUni = nameOfUni;
            FirstName = person.FirstName;
            LastName = person.LastName;
            DateBirth = person.DateBirth;
        }
        public Student(Student student)
        {
            Course = student.Course;
            Group = student.Group;
            Faculty = student.Faculty;
            NameOfUni = student.NameOfUni;
            FirstName = student.FirstName;
            LastName = student.LastName;
            DateBirth = student.DateBirth;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Сourse : {Course}");
            Console.WriteLine($"Group : {Group}");
            Console.WriteLine($"Faculty : {Faculty}");
            Console.WriteLine($"Name-Of-Univers : {NameOfUni}");
        }
    }
}
