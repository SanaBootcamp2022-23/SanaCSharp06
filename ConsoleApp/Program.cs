using ClassLibrary;
using System;
using System.Text;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

List<Person> persons = new List<Person>();
persons.Add(new Person("Олег", "Степушенко", new DateTime(1997, 02, 24)));
persons.Add(new Entrant("Антон", "Палій", new DateTime(2006, 11, 22), 180, 176, "Житомирська школа #5"));
persons.Add(new Teacher("Тетяна", "Вакалюк", new DateTime(1983, 11, 23), "Професор", "Інженерія програмного забезпечення", "ZDTU"));
persons.Add(new Student("Олег", "Степушенко", new DateTime(1997, 02, 24), 200, 200, "Житомирська школа #1", 1, "2A", "Інформаційно-комп’ютерних технологій ", "ZDTU"));
persons.Add(new LibraryUser("Максим", "Труш", new DateTime(1997, 11, 11), "BB245", new DateTime(2023, 2, 15), 100));



foreach (var person in persons)
{
    if (person is LibraryUser)
        Console.WriteLine("Користувач бібліотеки");
    else if (person is Teacher)
        Console.WriteLine("Викладач");
    else if (person is Student)
        Console.WriteLine("Студент");
    else if (person is Entrant)
        Console.WriteLine("Абітурієнт");
    else if (person is Person)
        Console.WriteLine("Людина");
    person.ShowInfo();
    Console.WriteLine("-----");
}

Console.WriteLine("Змінимо курс у студента");
foreach (var person in persons)
{
    if (person is Student)
    {
        (person as Student).Course = 2;
        (person as Student).ShowInfo();
    }
}
Console.WriteLine("-----");
