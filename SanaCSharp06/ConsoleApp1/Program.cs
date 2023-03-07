using System.Collections.Generic;
using ClassLibrary1;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("Nikita","Sehedin", "24.03.2004"));
            persons.Add(new Entrant("Nikita","Sehedin", "24.03.2004", 194, 11, "CityLyceum"));
            persons.Add(new Student("Nikita","Sehedin", "24.03.2004", 1, "ZIPZ-22-1", "IPZ", "ZPSU"));
            persons.Add(new Lecturer("Ivan", "Ivanov", "13.03.1973", "Dozent", "IPZ", "ZPSU"));
            persons.Add(new LibraryUser("Petro", "Petrenko", "09.06.2001", 11237, "22.08.2021", 14.5));
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ShowInfo());
            }
        }
    }
}