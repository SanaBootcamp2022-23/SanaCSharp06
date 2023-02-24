using System.Text;
using ClassLibrary;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

List<Person> persons = new List<Person>()
{
    new Person("Вадим", "Кузьмук", new DateTime(2000, 07, 08)),
    new Person("Вадим", "Кузьмук"),
    new Entrant("Вадим", "Кузьмук", new DateTime(2001, 08, 09), 190, 10, "Назва школи"),
    new Student("Вадим", "Кузьмук", new DateTime(2002, 09, 10), 1, "IPZm-22-1", "FICT", "ZTU"),
    new Teacher("Андрій", "Морозов", new DateTime(2003, 2, 24), "Pro-rector", "FICT", "ZTU"),
    new LibraryUser("Вадим", "Кузьмук", 13, new DateTime(2023, 2, 24),  100),
};

foreach (var person in persons)
{
    person.ShowInfo();
    Console.WriteLine(new string('-', 75));
}