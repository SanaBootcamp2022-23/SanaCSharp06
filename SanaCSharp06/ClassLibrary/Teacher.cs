using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : People
    {
        public string Position { get; set; }
        public string Kafedra { get; set; }
        public string Zaklad { get; set; }

        public Teacher(string name,string lastname,string date, string position, string kafedra, string zaklad) : base(name,lastname,date)
        { 
            Position = position;
            Kafedra = kafedra;
            Zaklad = zaklad;
        }

        public Teacher() { }

        public override void ShowInfo()
        {
            Console.WriteLine($"Teacher Info:\n" +
                $"Name: {this.FirstName}\n" +
                $"SurName: {this.LastName}\n" +
                $"Date: {this.Date}\n" +
                $"Position: {this.Position}\n" +
                $"Kafedra: {this.Kafedra}\n" +
                $"Zaklad: {this.Zaklad}\n");

        }
    }
}
