
using People;
List<Person> people = new List<Person>();
people.Add(new Person("Ivan","Plias"));
people.Add(new Person("NameTest1","SurNameTest1",new(1997,9,10)));
people.Add(new Applicant("NameTest2", "SurNameTest2", new(1997, 9, 10),123,6.6,"SchoolNameTest"));
people.Add(new Student("NameTest3", "SurNameTest3", new(1997, 9, 10),3,"BE-121","FacultyTest","UniversityNameTest"));
people.Add(new Teacher("NameTest4", "SurNameTest4", new(1997, 9, 10),"PositionTest","CathedraTest","UniversityNameTest"));
people.Add(new LibraryUser("NameTest5", "SurNameTest5", new(1997, 9, 10),3213123, new(2023, 2, 28), (decimal)1132.44));

foreach (var person in people)
{
    person.ShowInfo();
    Console.WriteLine("-----------------------");
}