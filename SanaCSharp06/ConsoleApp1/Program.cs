using ClassLibrary1;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        List<Person> persons = new List<Person>();
        persons.Add(new Person());
        persons.Add(new Abiturient());
        persons.Add(new Abiturient("Дмитро", "Стефанчук", new Date(8, 12, 2004), new ExamResults(181, 185, "Хімія", 178, "Історія України", 190), 11.1, "Радомишльська гімназія №2"));
        foreach (Person person in persons)
        {
            Console.WriteLine(person.ShowInfo());
        }
    }
}