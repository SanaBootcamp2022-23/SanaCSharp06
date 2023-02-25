using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SanaCSharp6
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Chair { get; set; }
        public string UniversityName
        {
            get; set;
        }
        public Teacher(string name, string surname, string dateOfBirth, string position, string chair, string universityNAme) : base(name, surname, dateOfBirth)
        {
            Position = position;
            Chair = chair;
            UniversityName = universityNAme;
        }
        public Teacher(string name, string surname, string dateOfBirth, string position, string chair) : base(name, surname, dateOfBirth)
        {
            Position = position;
            Chair = chair;

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Посада: {Position};\nКафедра: {Chair};";
            info += UniversityName == "" ? "" : $"\nНазва вищого навчального закладу: {UniversityName}";
            Console.WriteLine(info);
        }
    }
}
