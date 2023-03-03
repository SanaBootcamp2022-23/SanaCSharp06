using ClassLibrary;
using System.Text;

DateTime date = new DateTime(2005, 09,01);
Person person = new Person("Denis", "Gnom", date);
Console.WriteLine("Person info:");
person.ShowInfo();
Console.WriteLine("----------------------------------");


Entrant entrant = new Entrant(189.7, 10.8, "№19", person);
Console.WriteLine("Entrant info: ");
entrant.ShowInfo();
Console.WriteLine("----------------------------------");


Student student = new Student();
student.FirstName ="Denis";
student.LastName = "Gnom";
student.DateBirth = date;
student.Faculty = "Fict";
student.Course = 1;
student.NameOfUni = "ZTU";
student.Group = "IPZ-22-4";

Console.WriteLine("Student info: ");
student.ShowInfo();
Console.WriteLine("----------------------------------");


DateTime date1 = new DateTime(1974, 9, 21);
Teacher teacher = new Teacher("Dean", "Fict", "ZTU",
new Person("Dmytro", "Prokhorchuk", date1));
Console.WriteLine("Teacher info: ");
teacher.ShowInfo();
Console.WriteLine("----------------------------------");


DateTime date2 = new DateTime(1974, 9, 21);
Library_User library_User = new Library_User(3475, new DateTime(2023, 01, 23), 170.50, person);
Console.WriteLine("Library user info:");
library_User.ShowInfo();
