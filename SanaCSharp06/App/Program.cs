using ClassLibrary;

Human human = new Human("Yevhenii", "Biletskiy", new DateTime(2004, 4, 9));
Aplicant aplicant = new Aplicant("Ivan", "Kostolev", new DateTime(1999, 12, 11), 600, 10.2, "School 5");
Student student = new Student("Alex", "Volkov", new DateTime(2003, 9, 11), '1', "IPZ-21-3", "Fikt", "ZDTU");
Educator educator = new Educator("Yuriy", "Klarson", new DateTime(1979, 5, 14), "Lector", "Fikt", "ZDTU");
LibraryUser libraryUser = new LibraryUser("Bogdan", " Grin", new DateTime(2005, 7, 5), 1231, DateTime.Now, 10);

human.ShowInfo();
Console.WriteLine(new string('-', 15));
aplicant.ShowInfo();
Console.WriteLine(new string('-', 15));
student.ShowInfo();
Console.WriteLine(new string('-', 15));
educator.ShowInfo();
Console.WriteLine(new string('-', 15));
libraryUser.ShowInfo();