using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Human
    {
        protected string name;
        protected string surname;
        protected DateOnly birthdayDate;
        public Human()
        {
            name = string.Empty;
            surname = string.Empty;
            birthdayDate = DateOnly.MinValue;
        }
        public Human(string name, string surname, DateOnly birthdayDate)
        {
            this.name = name;
            this.surname = surname;
            this.birthdayDate = birthdayDate;
        }
        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string Name {get; set;}
        public string Surname { get; set;}
        public DateOnly BirthdayDate { get;set;}
        public virtual void ShowInfo()
        {
            Console.WriteLine("Person: ");
            Console.WriteLine($"  First name: {this.name}");
            Console.WriteLine($"  Last name: {this.surname}");
            Console.WriteLine($"  Date of birth: {this.birthdayDate}");
        }
    }
}