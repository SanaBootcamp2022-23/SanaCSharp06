using ClassLibrary;

DateTime dateTime = DateTime.Now;
Dictionary<string, double> zno = new Dictionary<string, double>();

zno.Add("Math", 181);
zno.Add("Ukrainian Language", 181);
zno.Add("English", 184);

var peopleList = new List<People>(5);

peopleList.Add(new People("Dmytro", "Demchenko", 8, 9, 2004));
peopleList.Add(new Entrant("Dmytro", "Demchenko", 8, 9, 2004, "Humanitarian gymnasium #1", 10.5, zno));
peopleList.Add(new Student("Dmytro", "Demchenko", 8, 9, 2004, 2, "IPZ-21-5", "FICT", "ZTU"));
peopleList.Add(new Teacher("Teacher", "Teacher", 1, 1, 1980, "Lector", "KKIK", "ZTU"));
peopleList.Add(new LibraryMember("Dmytro", "Demchenko", 8, 9, 2004, 1, dateTime, 250M));

foreach (var people in peopleList)
{ 
    Console.WriteLine(people.ShowInfo());
}