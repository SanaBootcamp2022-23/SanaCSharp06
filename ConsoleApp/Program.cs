using OOP2Library;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Person person = new("Микита", "Шевцов", new DateTime(2004, 2, 2));
            people.Add(person);

            Entrant entrant = new(person, "Гімназія №1", 75);
            entrant.AddEIA("Математика", 138);
            entrant.AddEIA("Авадакедавра", 200);
            entrant.AddEIA("Укр. Мова", 147);
            entrant.AddEIA("Іноз. Мова", 174);
            entrant.RemoveEIA("авадАкедавра");
            people.Add(entrant);

            foreach (var p  in people)
                Console.WriteLine(p.ShowInfo());
        }
    }
}