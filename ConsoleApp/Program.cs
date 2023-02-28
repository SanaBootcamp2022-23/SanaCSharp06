// See https://aka.ms/new-console-template for more information

using ClassLibrary;
using System.Security.Cryptography;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WindowWidth = 165;
Console.WindowHeight = 50;


Console.WriteLine("Демонстрація роботи класів\n");

var human = new Human("Олександр", "Крикля", new DateTime(1999, 1, 1));
human.ShowInfo();

var abiturient = new Abiturient("Анатолій", "Колесник", new DateTime(1999, 08, 27), 200, 11, "Загальноосвітня школа №6");

abiturient.ShowInfo();

var student = new Student("Кирило", "Івашков", new DateTime(1998, 05, 31), 2, "ІПЗМ-20-2", "ФІКТ", "Житомирський Державний Університет", 154, 9.3, "School 6 "); ;
student.ShowInfo();

var teacher = new Teacher("Віктор", "Бойко", new DateTime(1996, 1, 1), "Викладач програмування", "Інформатики та програмування", "Житомирська Політехніка");
teacher.ShowInfo();

var libraryUser = new LibraryUser("Богдан", "Колесник", new DateTime(1972, 04, 26), 1743, DateTime.Today.AddDays(-1), 273.68);
libraryUser.ShowInfo();

Human humanCopy = new(human);
Abiturient abiturientCopy = new(abiturient);
Student studentCopy = new(student);
Teacher teacherCopy = new(teacher);
LibraryUser libraryUserCopy = new(libraryUser);

Console.WriteLine("\nДемонстрація конструкторів копіювання\n");
humanCopy.ShowInfo();
abiturientCopy.ShowInfo();
studentCopy.ShowInfo();
teacherCopy.ShowInfo();
libraryUserCopy.ShowInfo();







