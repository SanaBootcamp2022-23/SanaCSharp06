using ClassLibrary;
using System.Collections.Generic;
Console.OutputEncoding = System.Text.Encoding.UTF8;
List<Person> People  = new List<Person>();
Applicant Applicant = new Applicant("Tom", "Tomson", new DateTime(2003, 1, 8), 60, 6.4f, "school");
Student Student = new Student("Peter", "Peterson", new DateTime(2005, 5, 11), "ZTU", "FIKT", 2, "IPZ-99-1", "Lyceum random name", 53.1f, 6.3f);
Teacher Teacher = new Teacher("Olga", "Olenko", new DateTime(2002, 12, 3), "Maths", "ZTU", "CS");
LibraryUser LibraryUser = new LibraryUser("Jo", "Black", new DateTime(2000, 1, 4), 100, 1, new DateTime(2021, 6,2 ));
Teacher.dateofbirth = new DateTime(1999, 11, 30);
People.Add(Applicant);
People.Add(Student);
People.Add(Teacher);
People.Add(LibraryUser);
foreach(Person p in People)
{
    Console.WriteLine(p.ShowInfo());
    Console.WriteLine("---------------------------------------------------------");
}