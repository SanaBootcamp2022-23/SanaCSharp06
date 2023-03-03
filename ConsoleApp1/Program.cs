using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Alec", "Boldwyn", new DateTime(1970, 2, 25));
        Applicant applicant = new Applicant(person, 25, 35, "278");
        Student student = new Student(applicant, 1, "IPZm","FIKT" , "ZTU");
        Teacher teacher = new Teacher(new Person("Nick", "Feoktistov",
            new DateTime(1965,5,20)),
            "Professor", "FIKT", "ZTU");
        LibraryUser libraryUser = new LibraryUser(student, 1);
        LibraryUser libraryUser1 = new LibraryUser(teacher, 1);
        LibraryUser libraryUser2 = new LibraryUser(new Person("Helga", "Lubimova",
            new DateTime(1983, 3, 18)), 2);
       libraryUser2.ShowInfo();
    }
}