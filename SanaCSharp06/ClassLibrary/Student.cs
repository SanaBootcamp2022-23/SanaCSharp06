using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Abiturient
    {
        public int Course { set; get; }
        public string Group { set; get; }
        public string Facult { set; get; }
        public string Univer { set; get; }

        public Student(int course,string group, string facult, string univer, string zaklad, Dictionary<string, int> dict, float docmark, string name, string lastname, string date) : base(zaklad, dict, docmark, name, lastname, date)
        {
            this.Course = course;
            this.Group = group;
            this.Facult = facult;
            this.Univer = univer;
        }

        public Student()
        { }

        public override void ShowInfo()
        {
            Console.WriteLine($"Student Info:\n" +
                $"Name: {this.FirstName}\n" +
                $"SurName: {this.LastName}\n" +
                $"Date: {this.Date}\n" +
                $"ZNO Marks:\n{this.ShowMarks()}\n" +
                $"Graduation mark: {this.DocMark}\n" +
                $"Zaklad: {this.Zaklad}\n" +
                $"Course: {this.Course}\n" +
                $"Group: {this.Group}\n" +
                $"Fakultet: {this.Facult}\n" +
                $"University: {this.Univer}\n");

        }
    }
}
