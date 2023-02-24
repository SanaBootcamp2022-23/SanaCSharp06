using OOP2;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
List<Person> persons = new List<Person>(5);
persons.Add(new Person("Євменчук", "Ярослав", new DateTime(1999, 8, 10)));
persons.Add(new Abiturient("Ivanenko", "Ivan", new DateTime(2005, 9, 29), 189, 9, "ЗОШ №3"));
persons.Add(new Student("Купрієнко", "Анатолій", new DateTime(2004, 10, 29), 1, "ІПЗ 22-2", "ФІКТ",
    "Житомирська Політехніка"));
persons.Add(new Teacher("Petrenko", "Petro", new DateTime(1988, 4, 1), "Лектор", "Вища математика",
    "Житомирський Державний Педагогічний Університет ім. Івана Франка"));
persons.Add(new LibraryEnjoyer("Darkholme", "Van", new DateTime(1972, 10, 24), 412623,
    new DateTime(2022, 2, 20), 300));
foreach (var person in persons)
    Console.WriteLine(person.ShowInfo());