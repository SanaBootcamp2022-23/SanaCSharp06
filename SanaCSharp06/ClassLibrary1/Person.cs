using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Person(string name, string lastName, Date birthDate)
        {
            this.Name = name;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
            BirthDate = new Date();
        }
        public Person() 
        {
            Name = "None";
            LastName = "None";
            BirthDate = new Date();
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Им'я: {Name}\n" +
                $"Прізвище: {LastName}\n" +
                $"Дата народження: {BirthDate}");
        }
    }
}
