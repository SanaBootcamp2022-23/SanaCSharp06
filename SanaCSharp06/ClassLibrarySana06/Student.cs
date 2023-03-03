using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySana06
{
    public class Student : Applicant
    {
        protected int course;
        protected string group;
        protected string faculty;
        protected string universityName;

        public int Course { get { return course; } set { if (value > 0 && value < 5) course = value; } }
        public string Group { get { return group; } set { group = value; } }
        public string Faculty { get { return faculty; } set { faculty = value; } }
        public string UniversityName { get { return universityName; } set { universityName = value; } }

        public Student(int course, string group, string faculty, string universityName)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            UniversityName = universityName;
        }

        public Student()
        {

        }

        public Student(Applicant applicant, int course, string group, string faculty, string universityName)
        : base(applicant.Person, applicant.Avg_ZNO_Points, applicant.Avg_SchoolSertificate_Points, applicant.Schoolname)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            UniversityName = universityName;
        }

        public Student(Person person, string firstname, string lastname, int dayofbirth, int mounthofbith, int yearofbirth)
            : base(person.Firstname, person.Lastname, person.DayOfBirth, person.MontthOfBirth, person.YearOfBirth) 
        {
            firstname = Firstname;
            lastname = Lastname;
            dayofbirth = DayOfBirth;
            mounthofbith = MontthOfBirth;
            yearofbirth = YearOfBirth;

        }

        public Student(Person person, int course, string group, string faculty, string universityName)
            : base(person.Firstname, person.Lastname, person.DayOfBirth, person.MontthOfBirth, person.YearOfBirth)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            UniversityName = universityName;
        }

        public Student(string firstname, string lastname, int dayofbirth, int mounthofbith, int yearofbirth,
            int avg_ZNO_points, double avg_SchoolSertificate_points, string schoolname, int course, string group, string faculty, string universityName)
            : base(firstname, lastname, dayofbirth, mounthofbith, yearofbirth, avg_ZNO_points, avg_SchoolSertificate_points, schoolname)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            UniversityName = universityName;
        }

        public Student(string firstname, string lastname, int dayofbirth, int mounthofbith, int yearofbirth) : base(firstname, lastname, dayofbirth, mounthofbith, yearofbirth)
        {
        }

        public static Student operator +(Student student, Applicant applicant)
        {
            return new Student(applicant, student.Course, student.Group, student.Faculty, student.universityName) { };
            
        }



        public override void ShowInfo()
        {
            if (avg_ZNO_points == 0 && firstname == "unset")
                Console.WriteLine($"Курс - {course}; Група - {group}; Факультет - {faculty}; ВНЗ - {universityName} ");
            else if (firstname != "unset" && avg_ZNO_points>0)
            {
                base.ShowInfo(); Console.WriteLine($"Курс - {course}; Група - {group}; Факультет - {faculty}; ВНЗ - {universityName}");
            }
            else
            {
                base.ShowInfo(); Console.WriteLine($"Курс - {course}; Група - {group}; Факультет - {faculty}; ВНЗ - {universityName}");
            }
            if (course == 0) base.ShowInfo();
        }

           
    }
}
