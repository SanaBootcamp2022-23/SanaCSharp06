using SanaCSharp06;

/* Testing all classes using List with output 
   information realised by virtual method */
//---------------------------------------------------------------------------------------------------------
List<Person> personList = new List<Person>();
personList.Add(new Person("Adam","Adamenko","31-09-1999")); 
personList.Add(new Professor("Jack","Jackson","2000","Headcoach","Sport","WAW"));
personList.Add(new Applicant("Mathew", "Wilson", "10-12-2010", 215, 10.2, "#6"));
personList.Add(new Student("Eden", "Haaland", "14-04-2001", 332, 11.4, "#23", 3, "WCY2101", "WAW"));
personList.Add(new LibraryUser("Thiago","Belucci","10-10-1988",4356789,"01-01-2000", 20)); 
foreach(Person person in personList)
    Console.WriteLine(person.GetFullInfo());
//---------------------------------------------------------------------------------------------------------

//Testing Set and Get in a class Person
Person person1 = new Person("John", "Been", "10.10.2020");
Console.WriteLine($"\n\n\nBefore:\n{person1.FirstName} {person1.LastName} ({person1.BirthDate})");
person1.BirthDate = "21.04.1999";
person1.FirstName = "Ivan";
person1.LastName = "Petrenko";
Console.WriteLine($"After\n{person1.FirstName} {person1.LastName} ({person1.BirthDate})");

//Testing Set and Get in a class LibraryUser
LibraryUser user1 = new LibraryUser(person1.FirstName, person1.LastName, person1.BirthDate, 13234567, "10.12.2012", 45);
Console.WriteLine($"\nBefore:\nID:{user1.LibraryId} ({user1.IssueDate}) - {user1.MonthlyPrice}$");
user1.LibraryId = 9087564;
user1.IssueDate = "20.12.2021";
user1.MonthlyPrice = 10;
Console.WriteLine($"After\nID:{user1.LibraryId} ({user1.IssueDate}) - {user1.MonthlyPrice}$");

//Testing Set and Get in a class Professor
Professor prof1 = new Professor("Jack", "Jackson", "2000", "Headcoach", "Sport", "WAW");
Console.WriteLine($"\nBefore:\n{prof1.FirstName} {prof1.LastName} Post:{prof1.Post} ({prof1.Department}) " +
    $"in {prof1.UniversityName}");
prof1.FirstName = "Igor";
prof1.LastName = "Gordienko";
prof1.Post = "Pre Ministr";
prof1.Department = "Government";
prof1.UniversityName = "Head University USA";
Console.WriteLine($"After:\n{prof1.FirstName} {prof1.LastName} Post:{prof1.Post} ({prof1.Department})" +
    $" in {prof1.UniversityName}");

//Testing Set and Get in a class Applicant
Applicant applicant1 = new Applicant("Mathew", "Wilson", "10-12-2010", 215, 10.2, "#6");
Console.WriteLine($"\nBefore:\n{applicant1.FirstName} {applicant1.LastName} from {applicant1.SchoolName}");
applicant1.FirstName = "Nazar";
applicant1.SchoolName = "Public school #2";
Console.WriteLine($"After:\n{applicant1.FirstName} {applicant1.LastName} from {applicant1.SchoolName}");

//Testing Set and Get in a class Student
Student stud1 = new Student("Eden", "Haaland", "14-04-2001", 332, 11.4, "School #23", 3, "WCY2101", "WAW");
Console.WriteLine($"\nBefore:\n{stud1.FirstName} {stud1.LastName} from {stud1.SchoolName} " +
    $"now in {stud1.UniversityName}");
stud1.FirstName = "Anton";
stud1.SchoolName = "Liceum #10";
stud1.UniversityName = "ZTSU";
Console.WriteLine($"After:\n{stud1.FirstName} {stud1.LastName} from {stud1.SchoolName} " +
    $"now in {stud1.UniversityName}");
