using OOP2Library;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new();

            Person person = new("Микита", "Шевцов", new DateTime(2000, 1, 1));
            people.Add(person);

            Entrant entrant = new(person, "Гімназія", 75);
            entrant.AddEIA("Математика", 138);
            entrant.AddEIA("Авадакедавра", 200);
            entrant.AddEIA("Укр. Мова", 141);
            entrant.AddEIA("Іноз. Мова", 179);
            entrant.RemoveEIA("авадАкедавра");
            people.Add(entrant);

            Student student = new(entrant, "ДУ \"ЖП\"", "ФІКТ", "1", "ІПЗ-22-2");
            people.Add(student);

            Teacher teacher = new(new Person("Іван", "Іваненко"), "ДУ \"ЖП\"",
                "Інженерія програмного забезпечення", "Доцент");
            people.Add(teacher);

            Person person2 = new("Петро", "Петросян", new DateTime(2003, 2, 24));
            LibraryMember libraryMember = new(person2, 239.99f);
            people.Add(person2);
            people.Add(libraryMember);

            foreach (var p  in people)
                Console.WriteLine(p.ShowInfo());
        }
    }
}