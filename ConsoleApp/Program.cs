using OOP2Library;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new("Микита", "Шевцов", new DateTime(2004, 2, 2));
            Entrant entrant = new(person, "Гімназія №1", 75);
            entrant.AddEIA("Математика", 138);
            entrant.AddEIA("Укр. Мова", 147);
            entrant.AddEIA("Іноз. Мова", 174);

            Console.WriteLine(person.ShowInfo());
            Console.WriteLine(entrant.ShowInfo());
        }
    }
}