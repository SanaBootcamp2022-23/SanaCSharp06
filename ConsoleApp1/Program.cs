using MyLibrary;

Person IvanAsPerson = new Person()
{
    FirstName = "First Name",
    LastName = "Last Name",
    Birthday = DateTime.Now,
};

Entrant IvanAsEntrant = new Entrant(IvanAsPerson)
{
    SchoolName = "School Name",
    PointsBySchool = 54,
    PointsByZNO = 94,
};

Student IvanAsStudent = new Student(IvanAsEntrant)
{
    UniversityName = "University Name",
    Course = 1,
    Faculty = "121 software engineering",
    Group = "IPZ-22-3",
};

Teacher IvanAsTeacher = new Teacher(IvanAsStudent)
{
    UniversityName = "University Name",
    Position = "Lecturer",
    Chair = "Programmer",
};

LibraryUser IvanAsLibraryUser = new LibraryUser(IvanAsTeacher)
{
    ReaderNumber = "1a-b",
    IssueDate = DateTime.Now,
    ContributionSize = 100,
};

List<Person> list = new List<Person>()
{
    IvanAsPerson,
    IvanAsEntrant,
    IvanAsStudent,
    IvanAsTeacher,
    IvanAsLibraryUser,
};

foreach (Person person in list)
    Console.WriteLine(person.ShowInfo());
