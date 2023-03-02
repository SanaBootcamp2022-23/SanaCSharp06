using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Teacher teacher = new Teacher("Тарас", "Василевич", "Декан", "ППВР", "ЖДУ");
            teacher.ShowInfo();
            Console.WriteLine();
            LibraryUser LibUser = new LibraryUser("Петро", "Петренко", 55433, "01.03.2023", 250);
            LibUser.ShowInfo();
            Console.WriteLine();
            Student student = new Student("Валерій", "П'ясківський","10.05.2002", 4, "РКТТ");
            student.ShowInfo();
            Console.WriteLine();
            Person person = new Person("Валерій","П'ясківський","10.05.2002");
            person.ShowInfo();
            Console.WriteLine();
            Entrant entrant = new Entrant("Валерій","П'ясківський", 10, "НСЗШ");
            entrant.ShowInfo();
        }
    }
}

