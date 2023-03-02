using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        private string Position { get; set; }
        private string Chair { get; set; }
        private string University { get; set; }

        public Teacher()
        {
             Position = "Unkonwn";
            Chair = "SP";
            University = "KPI";
    }
        public Teacher(DateTime dateOfBirthday, string name, string surname, string chair, string position, string university) 
            : base(dateOfBirthday, name, surname)
        {
            Chair = chair;
            Position = position;
            University = university;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Teacher:");
            Console.WriteLine($"Name:{Name} Surname: {Surname} " +
                $"Date of bitrthday: {DateOfBirthday.Day}/{DateOfBirthday.Month}/{DateOfBirthday.Year} Chair: {Chair} Position: {Position} " +
                $"University: {University}");
        }
    }
}
