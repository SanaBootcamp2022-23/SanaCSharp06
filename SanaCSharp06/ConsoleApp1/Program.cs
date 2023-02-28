using ClassLibrary1;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        List<Person> persons = new List<Person>
        {
            new Person(),
            new Abiturient(),
            new Abiturient("Дмитро", "Стефанчук", new Date(8, 12, 2004), new ExamResults(181, 185, "Хімія", 178, "Історія України", 190), 11.1, "Радомишльська гімназія №2"),
            new Student(),
            new Teacher("Ірина", "Погойдаш", new Date(5, 7, 1989), "Житомирська Політехніка", "121 Інженерія програмного забезпечення", "лектор"),
            new Teacher(),
            new LibraryUser()
        };
        foreach (Person person in persons)
        {
            Console.WriteLine($"{person.ShowInfo()}\n");
        }
    }
}