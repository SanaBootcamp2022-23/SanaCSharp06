using System;
using System.Security.Cryptography;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("John", "Doe", new DateTime(1995, 3, 15));
            human.ShowInfo();

            Applicant applicant = new Applicant("Jane", "Doe", new DateTime(2000, 5, 10), 190, 180, "High School");
            applicant.ShowInfo();

            Student student = new Student("Alex", "Smith", new DateTime(1998, 7, 20), 3, "A-101", "Computer Science", "University of XYZ");
            student.ShowInfo();

            Teacher teacher = new Teacher("David", "Johnson", new DateTime(1970, 1, 1), "Professor", "Computer Science", "University of XYZ");
            teacher.ShowInfo();

            LibraryUser libraryUser = new LibraryUser(12345, new DateTime(2022, 1, 1), 20);
            libraryUser.ShowInfo();

            Console.ReadKey();
        }
    }
}