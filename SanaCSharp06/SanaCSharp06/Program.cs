using ClassLibrary;
//People test
People people= new People("Dmytro", "Demchenko", 8, 9, 2004);

Console.WriteLine(people.ShowInfo());

//Entrant test
Dictionary<string, double> zno = new Dictionary<string, double>();

zno.Add("Math", 181);
zno.Add("Ukrainian Language", 181);
zno.Add("English", 184);

Entrant entrant = new Entrant("Dmytro", "Demchenko", 8, 9, 2004, "Humanitarian gymnasium #1", 10.5, zno);

Console.WriteLine(entrant.ShowInfo());

//Student test
Student student = new Student("Dmytro", "Demchenko", 8, 9, 2004, 2, "IPZ-21-5", "FICT", "ZTU");

Console.WriteLine(student.ShowInfo());

//Teacher test
Teacher teacher = new Teacher("Teacher", "Teacher", 1, 1, 1980, "Lector", "KKIK", "ZTU");

Console.WriteLine(teacher.ShowInfo());

//Library member test
DateTime dateTime = DateTime.Now;
LibraryMember lb = new LibraryMember("Dmytro", "Demchenko", 8, 9, 2004, 1, dateTime, 250M);

Console.WriteLine(lb.ShowInfo());
