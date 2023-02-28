using University;
using System;

namespace DriverProgram;
public class Program {
    public static void Main(string[] args) {
        Person person = new Person("Mike", "Ehrmantraut", new DateOnly(1950, 11, 5));
        person.ShowInfo();
        Console.WriteLine();

        Entrant entrant = new Entrant("Ted", "Jhonson", new DateOnly(2004, 10, 25), 10.3, "Richelieu lyceum");
        entrant.AddResult("Ukrainian", 194);
        entrant.AddResult("Math", 191);
        entrant.AddResult("Physics", 200);
        entrant.AddResult("English", 184);
        entrant.ShowInfo();
        Console.WriteLine();

        Student student = new Student("Walter Jr", "White", new DateOnly(1993, 5, 16), 
                1, "FICT", "KPI", "IP-14");
        student.ShowInfo();
        Console.WriteLine();

        Lecturer lecturer = new Lecturer("Walter", "White", new DateOnly(1958, 7, 8), 
                "Organic Chemistry department", "MTI", "Professor");
        lecturer.ShowInfo();
        Console.WriteLine();

        LibraryCustomer libraryCustomer = new LibraryCustomer("Jessy", "Pinkman", new DateOnly(1987, 12, 4), 
                43587832, new DateOnly(2000, 3, 17), 23.90);
        libraryCustomer.ShowInfo();
    }
}
