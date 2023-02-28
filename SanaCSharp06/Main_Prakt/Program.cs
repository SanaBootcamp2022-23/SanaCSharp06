using Library_Prakt;


// Creating a new instance of `Human` class
Human person = new("Danylo","Dziubchuk",new DateTime(2004,04,12));
Console.WriteLine("Human:");
person.ShowInfo();
Console.WriteLine();

// Creating a new instance of `Applicant` class by giving the `person` instance as an argument
Applicant applicant = new(person,100,10,"Zhytomyr");
Console.WriteLine("Applicant:");
applicant.ShowInfo();
Console.WriteLine();

// Creating a new instance of `Student` class by giving the `person` instance as an argument
Student student = new(person, 2, "VT-21-1", "FICT", "Zhytomyr Politecnich");
Console.WriteLine("Student:");
student.ShowInfo();
Console.WriteLine();

// Creating a new instance of `Teacher` class
Teacher teacher = new("John","Parkinson",new DateTime(1990,3,12), "English Language Teacher", "Department of Modern Languages", "Zhytomyr Politecnich");
Console.WriteLine("Teacher:");
teacher.ShowInfo();
Console.WriteLine();

// Creating a new instance of `LibraryUser` class
LibraryUser libraryUser = new("Patt", "Harictan", new DateTime(2002, 7, 23), 1523, new DateTime(2020, 10, 30), 100);
Console.WriteLine("Library User:");
libraryUser.ShowInfo();
Console.WriteLine();

