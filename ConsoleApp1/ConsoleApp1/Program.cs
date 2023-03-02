using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Human("John", "Wick", new DateTime(2001, 01, 01));
            var johnEntrant = new Entrant("John", "Wick", new DateTime(2001, 01, 01), "School №2", 340, 323);
            var johnStudent = new Student("John", "Wick", new DateTime(2001, 01, 01), 1, "A-C 19", "Arts and Humanities", "University of Cambridge");
            var johnTeacher = new Teacher("John", "Wick", new DateTime(2001, 01, 01), "Lecturer", "Arts and Humanities", "University of Cambridge");
            var johnLibraryUser = new LibraryUser("John", "Wick", new DateTime(2001, 01, 01), "192-93-22", "20.02.2019", 340);

            Console.WriteLine("Представник класу Human:");
            john.ShowInfo();
            Console.WriteLine("\nПредставник класу Entrant:");
            johnEntrant.ShowInfo();
            Console.WriteLine("\nПредставник класу Student:");
            johnStudent.ShowInfo();
            Console.WriteLine("\nПредставник класу Teacher:");
            johnTeacher.ShowInfo();
            Console.WriteLine("\nПредставник класу LibraryUser:");
            johnLibraryUser.ShowInfo();
        }
    }
}
