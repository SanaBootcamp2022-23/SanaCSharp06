using ClassLibrary;
using System.Text;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Person person = new Person("Іван", "Петров", "15.09.1996");
        Applicant applicant = new Applicant("Іван", "Петров", "15.09.1996", 189.3, 9.5, "ЗОШ №7 імені В.В.Бражевського");
        Student student = new Student("Іван", "Петров", "15.09.1996", 189.3, 9.5, "ЗОШ №7 імені В.В.Бражевського", 1, "ІПЗ-22-2", "ФІКТ", "Житомирська політехніка");
        Lecturer lecturer = new Lecturer("Іван", "Петров", "15.09.1996", 189.3, 9.5, "ЗОШ №7 імені В.В.Бражевського", 1, "ІПЗ-22-2", "Доцент", "ФІКТ", "Житомирська політехніка");
        LibraryUser user = new LibraryUser("Іван", "Петров", "15.09.1996", "1234-28", "25.12.2022", 220.5);

        Console.WriteLine("Приклад Person (людина):");
        Console.WriteLine();
        person.ShowInfo();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Приклад Applicant (абітурієнт):");
        Console.WriteLine();
        applicant.ShowInfo();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Приклад Student (студент):");
        Console.WriteLine();
        student.ShowInfo();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Приклад Lecturer (викладач):");
        Console.WriteLine();
        lecturer.ShowInfo();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Приклад Library User (користувач бібліотеки):");
        Console.WriteLine();
        user.ShowInfo();
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine();
        Console.ReadKey();
    }
}
