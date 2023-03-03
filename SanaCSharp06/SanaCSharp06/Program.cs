using ClassLibrary;
namespace SanaCSharp06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ваня", "Газмано", "12.23.1991");
            Applicant applic = new(person, new Dictionary<string, double>()
            {
                { "Українська мова", 192.3 },
                { "Математика",198.2 },
                {"Історія",178.4 }

            },10.8,"ЗОШ #12 Коростеня"
            );
            Student student = new(person, applic, "Перший курс", "ФІКТ", "ІПЗ-22-4", "Житомирська Політехніка");
            Teacher teacher = new Teacher(person, applic, student, "ЖДУ", "Професор кафедри", "КН");
            LibraryUser user = new(person, 12, "12.31.2015", 12.12);
            Console.WriteLine("-----------------------------------Person---------------------------------------------------");
            person.ShowInfo();
            Console.WriteLine("-----------------------------------Applicant------------------------------------------------");
            applic.ShowInfo();
            Console.WriteLine("------------------------------------Student-------------------------------------------------");
            student.ShowInfo();
            Console.WriteLine("-------------------------------------Teacher------------------------------------------------");
            teacher.ShowInfo();
            Console.WriteLine("------------------------------------Library-User--------------------------------------------");
            user.ShowInfo();
        }
    }
}