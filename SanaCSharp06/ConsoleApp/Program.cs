using System.Text;
using ClassLibrary;

namespace ConsoleApp
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Person person = new Person("Микита", "Короткий", "12.10.2002");
            Entrant entrant = new Entrant("Микита", "Короткий", "12.10.2002", 180, 9.9, "ЗОШ №16");
            Student student = new Student("Микита", "Короткий", "12.10.2002", 180, 9.9, "ЗОШ №16", 2, "ЗІПЗ-21-1", "ФІКТ", "ДУ \"Житомирська політехніка\"");
            Lecturer lecturer = new Lecturer("Василь", "Василішин", "15.09.1996", "Доцент", "ФІКТ", "ДУ \"Житомирська політехніка\"");
            LibrarySubscriber user = new LibrarySubscriber("Іван", "Петров", "15.09.1996", 346, "02.03.2023", 150);

            Console.WriteLine("Person:");
            Console.WriteLine();
            person.ShowInfo();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Entrant:");
            Console.WriteLine();
            entrant.ShowInfo();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Student:");
            Console.WriteLine();
            student.ShowInfo();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Lecturer:");
            Console.WriteLine();
            lecturer.ShowInfo();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("LibrarySubscriber:");
            Console.WriteLine();
            user.ShowInfo();
            Console.WriteLine("-----------------------------------");
            Console.ReadKey();
        }
    }

}
