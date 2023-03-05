using ClassLibrary1;

List <Person> persons = new List <Person> ();
persons.Add(new Person("Matvii", "Torop", 2004, 6, 2));
persons.Add (new Applicant ("ZG№3", 186, 200, 200,11, "Matvii", "Torop", 2004, 6, 2));
persons.Add(new Student(1, 4, 121, "ZP", "ZG№3", 186, 200, 200,11, "Matvii", "Torop", 2004, 6, 2));
persons.Add(new Teacher("Teacher", "Aboba", "ZP", "Matvii", "Torop", 2004, 6, 2));
persons.Add(new LibraryVisitor(1234, 2023, 12, 11, 1500, "Matvii", "Torop", 2004, 6, 2));

foreach(Person person in persons)
{
    Console.WriteLine(person.GetInfo());
    Console.WriteLine("\n-----------------------------------------------------------------------");
}