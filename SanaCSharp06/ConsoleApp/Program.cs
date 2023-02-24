using System.Text;
using ClassLibrary;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

List<Person> persons = new List<Person>()
{
    new Person("Вадим", "Кузьмук", new DateTime(2000, 07, 08)),
    new Person("Вадим", "Кузьмук"),
    new Entrant("Вадим", "Кузьмук", new DateTime(2001, 08, 09), 190, 10, "Назва школи")
};

foreach (var person in persons)
{
    person.ShowInfo();
    Console.WriteLine(new string('-', 75));
}