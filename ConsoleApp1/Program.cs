// See https://aka.ms/new-console-template for more information
using ClassLibrary;
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Person person = new Person("Олександр", "Волков");
Entrant entrant = new Entrant("Тарас", "Шевченко", new DateTime(1800, 10, 17),600,12);
Student student = new Student("Григорій", "Сковорода", new DateTime(2001, 12, 17), 600, 12, "ліцей 25", 4, "Житомирська політехніка");
Teacher teacher = new Teacher("Володимир", "Великий", new DateTime(1999, 12, 17), "професор", "комп'ютерних наук");
LibraryUser libraryUser = new LibraryUser("Леся", "Українка", new DateTime(1991, 12, 17), 12, 565);

person.ShowInfo();
entrant.ShowInfo();
student.ShowInfo();
teacher.ShowInfo();
libraryUser.ShowInfo();