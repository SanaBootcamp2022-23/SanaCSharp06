using System.Text;
using SanaCSharp06.ClassLibrary;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
//Створюємо список із Person-ів для демонстрації поліморфізму
//Додамо туди по одному об'єкту кожного із створених класів: наслідників Person-у та сам Person
List<Person> persons = new List<Person>()
{
    new Person("Petro", "Petrenko", new DateTime(1998, 11, 10)),
    new Applicant("Ivan", "Ivanenko", new DateTime(2002, 12, 12), 195, 11, "SZOSH"),
    new Student("Dmytro", "Dmytrenko", new DateTime(2003, 6, 1), 3, "IPZ-20-1", "FICT", "DUZP"),
    new Teacher("Vasyl", "Vasylenko", new DateTime(1982, 3, 23), "Lector", "KN", "DUZP"),
    new LibraryUser("Andriy", "Andiyenkno", new DateTime(2000, 4, 15), "1A3B1234", 150)
};
//Викликаємо реалізовані методи для кожного об'єкту
foreach (var person in persons)
{
    person.ShowInfo();
    Console.WriteLine(new string('-', 20));
}