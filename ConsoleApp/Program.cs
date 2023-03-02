using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Human human = new Human("Василенко", "Максим", "28.06.2000");
            human.ShowInfo();
            Teacher teacher = new Teacher("Іван", "Іванов", "16.02.1982", "Викладач", "ФІКТ", "Житомирська політехніка");
            teacher.ShowInfo();
            Applicant applicant = new Applicant("Петров", "Петро", "24.08.2002", 150, 175, 140, (float)7.5, "ЗОШ №28");
            applicant.ShowInfo();
            Student student = new Student("Петро", "Головатюк", "11.12.1900", "перший", "ІПЗ-22-1", "ФІКТ", "Житомирська політехніка");
            student.ShowInfo();
            LibraryUser libraryUser = new LibraryUser("Віталій", "Андреєв", "17.12.1988", "XM151456", "17.12.1111", "300 UAH");
            libraryUser.ShowInfo();
        }
    }
}
