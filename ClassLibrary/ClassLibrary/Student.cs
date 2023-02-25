using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Person
    {
        private int course = 1;
        private string group = "11-6";
        private string faculty = "Кібербезпека";
        private string universityName = "ЖТУ";
        public int Course { get => course;
            set
            {
                if (value > 0)
                    course = value;
            }
        }
        public string Group { get => group;
            set
            {
                if (value.Length >= 2)
                    group = value;
            }
        }
        public string Faculty { get => faculty;
            set
            {
                if (value.Length >= 2)
                    faculty = value;
            }
        }
        public string UniversityName { get => universityName;
            set
            {
                if (value.Length >= 3)
                    universityName = value;
            }
        }

        public Student(string FirstName, string LastName, string DateOfBirth, int Course,string Group, string Faculty, string UniversityName)
            :base(FirstName, LastName, DateOfBirth)
        {
            this.Course = Course;
            this.Group = Group;
            this.Faculty = Faculty;
            this.UniversityName = UniversityName;
        }
        public Student(string FirstName, string LastName, string Group, string Faculty, string UniversityName)
            : base(FirstName, LastName)
        {
            this.Group = Group;
            this.Faculty = Faculty;
            this.UniversityName = UniversityName;
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} \nУніверситет: {UniversityName} \nФакультет: {Faculty} \nКурс: {Course} \nГрупа: {Group}";
        }
    }
}
