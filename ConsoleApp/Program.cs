using University;


List<Person> people = new List<Person>();
people.Add(new Person("Yaroslav", "Mykhalchuk", new(1998, 9, 30)));
people.Add(new Person("Volodymyr", "Zelenskiy"));
people.Add(new Applicant("Valentyna", "Gaydamaka", new(2001, 10, 27), 186.4, 10.9, "Secondary school №5"));
people.Add(new Student("Ivan", "Dragomanov", new(2000, 5, 14), 3, "IPZm-22-2", "FIKT", "ZSTU"));
people.Add(new Teacher("Semen", "Ivanov", new(1988, 7, 12), "Lector", "Computer Science", "ZSTU"));
people.Add(new LibraryUser("Andriy", "Petrov", new(2002, 12, 14), 165423154, new(2023, 1, 28), 24));

foreach (var person in people)
{
    person.ShowInfo();
    Console.WriteLine("-------------------------------------");
}