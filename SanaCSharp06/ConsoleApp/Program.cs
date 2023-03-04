
using ClassLibrary;

List<Person> people = new List<Person>();
people.Add(new Person("Max", "Tarantino", new DateTime(1965, 11, 23)));
people.Add(new Person("Jony", "Jekson", new DateTime(1965, 11, 23)));
people.Add(new CertificateZNO("Roman", "Fikys", new DateTime(1965, 11, 23),190,130,165));
people.Add(new Enrollee("Rik", "Salovan", new DateTime(1965, 11, 23),190,130,165, 9));
people.Add(new LibraryUser("Morty", "Mort", new DateTime(1975, 10, 21),"876ad45sd", new DateTime(2022, 1, 3),50));
people.Add(new Student("Andry", "Sager", new DateTime(1999, 8, 16), 190, 130, 165, 9 , 4 ,"35b", "Geography", "ZDU"));
people.Add(new Teacher("Sandy", "Cuper", new DateTime(1966, 9, 14), "teacher of geography", "Geography","MIT"));

foreach (Person item in people)
{
    Console.WriteLine(item.ShowInfo());
    Console.WriteLine();

}
Console.WriteLine("Hello");

