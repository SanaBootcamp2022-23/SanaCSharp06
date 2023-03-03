using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }

        public Person(string firstName, string lastName, string birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = firstName;
        }

        public Person()
        {
            FirstName = "Сергій";
            LastName = "Марчук";
            BirthDate = "27, 12, 1991";
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"First name: {FirstName} + Last name^ {LastName}");
        }
    }
}