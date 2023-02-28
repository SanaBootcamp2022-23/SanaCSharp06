using ClassLibrary;
using System.Text;

namespace ConsoleApp
{
	internal class Program
	{
		static void Decorator() => Console.WriteLine("----------------------------------");
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;

			DateTime date = new DateTime(2005, 09, 22);
			Person person = new Person("Slava", "Varn", date);
			Console.WriteLine("Person info:");
			person.ShowInfo();
			Decorator();
			

			Enrollee enrollee = new Enrollee(191.1, 11.1, "ZTU", person);
			Console.WriteLine("Enrollee info: ");
			enrollee.ShowInfo();
			Decorator();


			Student student = new Student();
			student.SetFirstName("Андрій");
			student.SetSecondName("Вознюк");
			student.SetDateOfBirth(new DateTime(2004, 12, 21));
			student.SetFaculty("ФІКТ");
			student.SetCourse(1);
			student.SetNameOfUni("ЖТУ");
			student.SetGroup("ІПЗ-22-4");

			Console.WriteLine("Група: " + student.GetGroup());
			Console.WriteLine("Student info: ");
			student.ShowInfo();
			Decorator();


			Teacher teacher = new Teacher("Старший викладач", "ПО", "ЖТУ",
				new Person("Богдан", "Богданенко", new DateTime(1980, 10, 14)));
			Console.WriteLine("Teacher info: ");
			teacher.ShowInfo();
			Decorator();


			LibraryUser libraryUser = new LibraryUser(12, new DateTime(2023, 01, 23), 12.45m, person);
			Console.WriteLine("Library user info:");
			libraryUser.ShowInfo();
			Decorator();

		}
	}
}