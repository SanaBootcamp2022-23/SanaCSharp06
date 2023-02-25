using ClassLibrary;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

List<Person> person = new List<Person>(15);
person.Add(new Person("Іван", "Іванов"));
person.Add(new Person("Дмитро", "Дмитренко", "01.01.1999"));

person.Add(new Applicant("Іван", "Дмитренко", 294, 80));
person.Add(new Applicant("Дмитро", "Іванов", "10.10.1999", 140, 73, "ЗОШ №6"));

person.Add(new Student("Петро", "Іванов", "19-7", "123", "ЖТДУ №5"));
person.Add(new Student("Назар", "Червоний", "20.12.1999", 2, "18-8", "201", "ЖТДУ №4"));

person.Add(new Teacher("Микита", "Рожевий", "викладач", "ЖТДУ №4"));
person.Add(new Teacher("Дмитро", "Червоний", "23.10.1973", "викладач", "КН", "ЖТДУ №4"));

person.Add(new LibraryUser("Леонід", "Петренко", 23, "10.10.2022"));
person.Add(new LibraryUser("Ігор", "Блакитний", "5.07.1992", 23, "10.10.2022", 233.15f));

foreach(Person p in person)
{
    Console.WriteLine(p.ShowInfo() + "\n");
}

