using ClassLibrary;
Console.OutputEncoding = System.Text.Encoding.Default;
List<Person> persons = new List<Person>();
persons.Add(new Person("Ivan", "Ivanov", new DateTime(2005, 8, 7)));
persons.Add(new Person());
persons.Add(new Applicant("Alexander", "Biliy", new DateTime(1988, 8, 7), 187.3, 10.0, "ЗОШ №30"));
persons.Add(new Student("Viktor", "Sirskiy", new DateTime(1988, 8, 7), "1", "IPZ-22-1", "FICT", "ZSTU", 187.3, 9.8, "Ліцей №1"));
persons.Add(new Teacher("Maxim", "Melnyk", new DateTime(1968, 8, 7), "Professor", "IPZ", "ZSTU"));
persons.Add(new LibraryUser("Igor", "Lomonosov", new DateTime(1968, 8, 7), 69, new DateTime(2023, 2, 27), 100.50));
foreach (Person person in persons)
{
    person.ShowInfo();
    Console.WriteLine();
}

