using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Kafedra { get; set; }
        public string University { get; set; }
        public Teacher(string name, string surname, string position, string kafedra, string university ) : base(name,surname)
        {
            Position = position;
            Kafedra = kafedra;
            University = university;
        }
        public Teacher(string name, string surname, string university) : base(name,surname)
        {
            University = university;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада: {Position}\nКафедра: {Kafedra}\nНавчальний заклад: {University}\n");
        }
        public Teacher()
        {

        }
    }
    }
