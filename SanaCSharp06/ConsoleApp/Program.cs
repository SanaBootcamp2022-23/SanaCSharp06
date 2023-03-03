using ClassLibrary;

People people = new People("Vadim","Bondar","13.09.2004");
people.ShowInfo();
Console.WriteLine("\n");

Abiturient abiturient = new Abiturient("School",new Dictionary<string, int> (){ { "Math",150 }, { "English", 180 } },10,"Vadim", "Bondar", "13.09.2004");
abiturient.ShowInfo();
Console.WriteLine("\n");

Student stud = new Student(1,"IPZ","FICT", "ZTDU", "School", new Dictionary<string, int>() { { "Math", 150 }, { "English", 180 } }, 10, "Vadim", "Bondar", "13.09.2004");
stud.ShowInfo();
Console.WriteLine("\n");


Teacher teach = new Teacher("Vadim", "Bondar", "13.09.2004","teacher","PCT","ZTDU");
teach.ShowInfo();
Console.WriteLine("\n");

LibraryUser libUser = new LibraryUser("Vadim", "Bondar", "13.09.2004","066","30.03.2005",300);
libUser.ShowInfo();
Console.WriteLine("\n");