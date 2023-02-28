using ClassLibrary;
using System.Text;

namespace SanaCSharp06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Human human = new Human("Andrew", "Vozniuk");
            human.ShowInfo();
            Console.WriteLine("\n");

            Student student = new Student("Andrew","Vozniuk",1,"IPZ-224","FICT","ZDTU");
            student.ShowInfo();
            Console.WriteLine("\n");

            LibraryUser user = new LibraryUser("Andrew", "Vozniuk", 12, 11, 1992, 12, 8, 2020, 120);
            user.ShowInfo();
            Console.WriteLine("\n");

            var entrant = new Entrant("Andrew", "Vozniuk", 20, 12, 2004,192,"IPZ-22-4", 10.2, "Ecological Lyceum 24");
            entrant.ShowInfo();
            Console.WriteLine("\n");

            Tutor tutor = new Tutor("Andrii", "Morozov", "Boss", "Фікт", "Житомирська Політехніка");
            tutor.ShowInfo();
        }
    }
}