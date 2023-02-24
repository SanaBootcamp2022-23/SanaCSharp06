

using SanaCSharp06;

class Program
{
    static void Main()
    {
        PersonalDateClass testDate = new PersonalDateClass(20, 12, 2002);

        Entrant testEntrant = new Entrant("Vadym", "Dukhopela", testDate, 9, 8, "Gymnasium № 5");
        Student testStudent = new Student("Vadym", "Dukhopela", testDate, "Zhytomyr Polytechnic", 3, "KB201", "IKT");
        Teacher testTeacher = new Teacher("Vadym", "Dukhopela", testDate, "Boss of the boss", "Main", "Zhytomyr Polytechnic");
        PersonalDateClass dateOfIssue = new PersonalDateClass(20, 12, 2002);
        LibraryUser testLibraryUser = new LibraryUser("Vadym", "Dukhopela", testDate, "28412794", dateOfIssue, 399);

        FullListOfUsers testList = new FullListOfUsers(testEntrant, testStudent, testTeacher, testLibraryUser);
        testList.CallAllUsers();
    }
}


class FullListOfUsers
{
    private People[] test;
    public FullListOfUsers(params People[] test)
    {
        this.test = test;
    }

    public void CallAllUsers()
    {
        foreach (var people in test) 
        {
            people.ShowInfo();
            Console.WriteLine("\n\n");
        }
    }
}
