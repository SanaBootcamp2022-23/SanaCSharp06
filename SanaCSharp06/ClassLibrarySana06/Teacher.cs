using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySana06
{
    public class Teacher:Person
    {
        protected string status;
        protected string chair;
        protected string universityName;

        public string Status { get { return status; } set { status = value; } }
        public string Chair { get { return chair; } set { chair = value; } }
        public string UniversityName { get { return universityName; } set { universityName = value; } }

        public Teacher() { }
        public Teacher(string status, string chair, string universityName)
        {
            Status = status;
            Chair = chair;
            UniversityName = universityName;
        }
       
        public Teacher(Person person, string status, string chair, string universityName)
            : base(person.Firstname, person.Lastname, person.DayOfBirth, person.MontthOfBirth, person.YearOfBirth)
        {
            Status = status;
            Chair = chair;
            UniversityName = universityName;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"(Посада - {status}, Кафедра - {chair}, ВНЗ - {universityName})");
        }
    }
}
