using ClassLibrary;
using System;


Human human = new Human("Dmytro", "Burylko", new DateOnly(2003, 11, 27));
Entrant entrant = new Entrant("Ivan", "Ivanenko", new DateOnly(2002, 12, 28), 187, 10, "Lyceum №1");
Student student = new Student("Andriy", "Andriyenko", new DateOnly(2001, 10, 29), 2,
    "BC-12", "FBMI", "KPI");
Professor professor = new Professor("Petro", "Petrenko", new DateOnly(1965, 2, 24),
    "Lecturer", "ATAP", "KPI");
LibraryClient libraryclient = new LibraryClient("Vasyl", "Vasylenko", new DateOnly(2000, 9, 26), 32, new DateOnly(2025, 6, 23), 25.62);

human.ShowInfo();
entrant.ShowInfo();
student.ShowInfo();
professor.ShowInfo();
libraryclient.ShowInfo();
