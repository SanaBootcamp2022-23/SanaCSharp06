using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp6
{
    public class Student:Person
    {
        public string YearOfStudying { get; set; }
        public string NameOfGroup { get; set; }
        public string NameOfFaculty { get; set; }
        public string NameOfUniversity { get; set; }

        public Student(string yearOfStudying, string nameOfGroup, string nameOfFaculty, string nameOfUniversity,string name,string surname,string birth):base(name,surname,birth)
        {
            YearOfStudying = yearOfStudying;
            NameOfGroup = nameOfGroup;
            NameOfFaculty = nameOfFaculty;
            NameOfUniversity = nameOfUniversity;
        }
        public Student(string yearOfStudying, string nameOfGroup, string nameOfFaculty, string name, string surname, string birth) : base(name, surname, birth)
        {
            YearOfStudying = yearOfStudying;
            NameOfGroup = nameOfGroup;
            NameOfFaculty = nameOfFaculty;
           
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Курс навчання: {YearOfStudying};\nНазва групи: {NameOfGroup};\nНазва факультету: {NameOfFaculty};";
            info += NameOfUniversity == "" ? "" : $"\nНазва вищого навчального закладу: {NameOfUniversity}";
            Console.WriteLine(info);
        }
    }
}
