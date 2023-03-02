using System.Xml.Linq;

namespace ClassLibrary

{
    public class Person
    {
        public DateTime DateOfBirthday { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            DateOfBirthday = new DateTime(2004,6,15,0,0,0);
            Name = "Unknown";
            Surname = "Unknown";
    }
        public Person(DateTime dateOfBirthday, string name, string surname)
        {
            DateOfBirthday = dateOfBirthday;
            Name = name;
            Surname = surname;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Person:");
            Console.WriteLine($"Name:{Name} Surname: {Surname} Date of bitrthday: {DateOfBirthday.Day}/{DateOfBirthday.Month}/{DateOfBirthday.Year}");
        }
    }
}
