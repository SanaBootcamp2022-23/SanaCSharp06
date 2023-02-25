using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        private string position = "Викладач";
        private string department = "КН";
        private string universityName = "ЖТУ";
        public string Position { get => position;
            set
            {
                if (value.Length >= 3)
                    position = value;
            }
        }
        public string Department { get => department;
            set
            {
                if (value.Length >= 3)
                    department = value;
            }
        }
        public string UniversityName
        {
            get => universityName;
            set
            {
                if (value.Length >= 3)
                    universityName = value;
            }
        }

        public Teacher(string FirstName, string LastName, string DateOfBirth, string Position, string Department, string UniversityName)
            :base(FirstName, LastName, DateOfBirth)
        {
            this.Position = Position;
            this.Department = Department;
            this.UniversityName = UniversityName;
        }
        public Teacher(string FirstName, string LastName, string Position, string UniversityName)
           : base(FirstName, LastName)
        {
            this.Position = Position;
            this.UniversityName = UniversityName;
        }

        public override string ShowInfo()
        {
            return $"{base.ShowInfo()} \nПосада: {Position} \nКафедра: {Department} \nВищий навчальний заклад: {UniversityName}";
        }
    }
}
