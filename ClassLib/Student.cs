using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Student : Person
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public Student(string name, string surname, string birthDate, int course, string group, string faculty, string university) : base(name,surname,birthDate)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public Student(string name, string surname, string birthDate, int course, string faculty) : base(name,surname,birthDate)
        {
            Course = course;
            Faculty = faculty;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Курс: {Course}\nГрупа: {Group}\nФакультет: {Faculty}\nУніверситет: {University}");
        }
        public Student()
        {

        }
    }
}
