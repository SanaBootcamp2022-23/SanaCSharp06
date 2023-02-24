using System.Text;
using SanaCSharp06ClassLibrary;

namespace SanaCSharp06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("The Library Program\n");

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            var humanList = new List<Human>()
            {
                new Human("Артем", "Волощенко"),
                new Entrant(),
                new Student("Андрій", "Вернидуб", new Date(2005, 2, 18, 0, 0), 1, "КІ-22-1", "ФІКТ"),
                new Teacher("Петро", "Моставчук", new Date(1980, 6, 7, 0, 0), "старший викладач", "ФІКТ"),
                new UserLibrary()
            };

            foreach (var human in humanList)
            {
                Console.ForegroundColor = human switch
                {
                    Teacher => ConsoleColor.Cyan,
                    Student => ConsoleColor.Magenta,
                    UserLibrary => ConsoleColor.DarkRed,
                    Entrant => ConsoleColor.Gray,
                    Human => ConsoleColor.Yellow,
                    _ => Console.ForegroundColor
                };

                Console.WriteLine(human.ShowInfo() + "\n");
                Console.ResetColor();
            }
        }
    }
}