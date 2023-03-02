using System.Xml.Linq;

namespace ClassLibrary

{
    public class Person
    {
        public string DateOfBirthday { get; set; } = "12.06.2004";
        public string Name { get; set; } = "Unknown";
        public string Surname { get; set; } = "Unknown";

        public Person()
        {

        }
        public Person(string dateOfBirthday, string name, string surname)
        {
            DateOfBirthday = dateOfBirthday;
            Name = name;
            Surname = surname;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Person:");
            Console.WriteLine($"Name:{Name} Surname: {Surname} Date of bitrthday: {DateOfBirthday}");
        }
    }
}
