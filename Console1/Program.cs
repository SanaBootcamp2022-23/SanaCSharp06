using Library;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Lyudina lyud = new Lyudina();
            Abiturient abiturient = new Abiturient();
            Student student = new Student();
            Teacher teacher = new Teacher();
            Library library = new Library();
            Console.WriteLine("Клас Людина:");
            lyud.ReadInfo();
            Console.Clear();
            Console.WriteLine("Клас Абітурієнт:");
            abiturient.ReadInfo();
            Console.Clear();
            Console.WriteLine("Клас Судент:");
            student.ReadInfo();
            Console.Clear();
            Console.WriteLine("Клас Викладач:");
            teacher.ReadInfo();
            Console.Clear();
            Console.WriteLine("Клас Користувач бібліотеки:");
            library.ReadInfo();
            Console.Clear();
            Console.WriteLine("Людина:");
            lyud.ShowInfo();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Абітурієнт:");
            abiturient.ShowInfo();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Студент:");
            student.ShowInfo();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Викладач:");
            teacher.ShowInfo();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Користувач бібліотеки:");
            library.ShowInfo();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
