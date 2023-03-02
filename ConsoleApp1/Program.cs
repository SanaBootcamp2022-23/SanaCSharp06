using ClassLibrary1;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Entrant entrant = new Entrant("Петро", "Зварич", new DateTime(2006, 3, 4), 194, 11, "Гімназія №34");
            entrant.ShowInfo();
            Console.WriteLine();
            Student student = new Student("Олександр", "Зайцев", new DateTime(2005, 2, 13), 1, 4, "ФІКТ", "ЖДТУ");
            student.ShowInfo();
            Console.WriteLine();
            Teacher teacher = new Teacher("Іван", "Мельник", new DateTime(1987, 1, 17), "Декан", "ФІКТ", "ЖДТУ");
            teacher.ShowInfo();
            Console.WriteLine();
            LibraryUser libraryuser = new LibraryUser("Данило", "Степанчук", new DateTime(2003, 8, 6), 531, new DateTime(2023, 2, 26), 50);
            libraryuser.ShowInfo();
        }
    }
}