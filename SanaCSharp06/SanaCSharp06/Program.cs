using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SanaCSharp06.Classes;

namespace ISMPrakt10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ban", "Bandera", new DateTime(2003, 6, 15));
            Applicant applicant = new Applicant("Danyil", "Bandera", new DateTime(2004, 6, 15), new List<ZNOResult>() { new ZNOResult("Math", 190), new ZNOResult("History", 180) }, 11.1f, "102");
            Student student = new Student("Danyil", "Tuhaienko", new DateTime(2004, 1, 15), new List<ZNOResult>() { new ZNOResult("Math", 195), new ZNOResult("History", 163) }, 10.2f, "102", "1", "MMO-166", "Архітектура", "Imaginary");
            Teacher teacher = new Teacher("San", "Chukov", new DateTime(1985, 5, 9), "Ректор", "ПРО-51", "Imaginary");
            LibraryUser libraryUser = new LibraryUser("Jean", "Lo", new DateTime(2002, 12, 6), 1516, new DateTime(2020, 12, 4), 159.9);

            person.ShowInfo();
            applicant.ShowInfo();
            student.ShowInfo();
            teacher.ShowInfo();
            libraryUser.ShowInfo();
        }
    }
}
