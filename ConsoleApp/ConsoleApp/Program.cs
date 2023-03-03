using ClassLib;
using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;

Student student = new Student("Петро", "Петренко", "24.03.2002", 4, "КН-1", "Інформатики", "ЖДТУ");
student.ShowInfo();
Console.WriteLine();

Teacher teacher = new Teacher("Іван", "Іванов", "Старший викладач кафедри");
teacher.ShowInfo();
Console.WriteLine();

Entrant entrant = new Entrant("Андрій", "Возний", 5, "ЗОШ № 7");
entrant.ShowInfo();
Console.WriteLine();

LibraryUser libraryUser = new LibraryUser("Сергій", "Петров", "24.04.1990", 234, "12.12.2023", 214);
libraryUser.ShowInfo();
