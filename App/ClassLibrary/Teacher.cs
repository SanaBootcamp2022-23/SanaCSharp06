using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        protected string position { get; set; }
        protected string kafedra { get; set; }


        public Teacher(string firstName, string lastName, string position, string kafedra) : base(firstName, lastName)
        {
            this.position = position;
            this.kafedra = kafedra;
        }
        
        public virtual void ShowInfo()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($" Name: {this.firstName}");
            Console.WriteLine($" Surname: {this.lastName}");
            Console.WriteLine($" Position: {this.position}");
            Console.WriteLine($" Kafedra: {this.kafedra}");
            Console.WriteLine("----------------------------------");
        }
    }

}
