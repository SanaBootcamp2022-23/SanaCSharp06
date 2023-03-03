using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Teacher : Person
    {
        string Position { get; set; }
        string Chair { get; set; }
        string University { get; set; }
        public Teacher(string firstName, string lastName, string birthDate, 
            string position, string chair, string university) : base(firstName, lastName, birthDate)
        {
            Position = position;
            Chair = chair;
            University = university;
        }

        public Teacher()
        {

        }

        public Teacher(string firstName, string lastName, string position) : base(firstName, lastName)
        {
            Position = position;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {Position}\n" +
                $"Chair: {Chair}\n" +
                $"University: {University}\n");
        }
    }
}
