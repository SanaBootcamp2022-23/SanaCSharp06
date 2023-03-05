using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Entrant
    {
        //методи для встановлення та читання значень
        public int Course { get; set; }                 
        public string Group { get; set; }              
        public string Faculty { get; set; }  
        public string СollegeName { get; set; }

        //конструктори з параметрами
        public Student(string name, string surname, string dateOfBirth, double scoreOfZNO, double educationScore,
         string school, int course, string group, string faculty, string collegeName)
            : base(name, surname, dateOfBirth, scoreOfZNO, educationScore, school)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            СollegeName = collegeName;
        }
        public Student(string name, string surname, string dateOfBirth, double scoreOfZNO, double educationScore,
         string school, string group, string faculty, string collegeName)
            : base(name, surname, dateOfBirth, scoreOfZNO, educationScore, school)
        {
            Course = 0;
            Group = group;
            Faculty = faculty;
            СollegeName = collegeName;
        }
        
        //віртуальний метод ShowInfo()
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Курс: {Course}");
            Console.WriteLine($"Група: {Group}");
            Console.WriteLine($"Факультет: {Faculty}");
            Console.WriteLine($"Назва ВНЗ: {СollegeName}");
        }
    }

}
