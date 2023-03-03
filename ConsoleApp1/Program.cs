using System.Collections;
using ClassLibrary;

class Program
{
    static void Main(string[] args)
    {
        ArrayList array = new ArrayList();

        Person person = new Person("Alec", "Boldwyn", new DateTime(1970, 2, 25));
        array.Add(person);

        Applicant applicant = new Applicant(person, 198, 12, "278");
        array.Add(applicant);

        Student student = new Student(applicant, 1, "IPZm","FIKT" , "ZTU");
        array.Add(student);

        Teacher teacher = new Teacher(new Person("Nick", "Feoktistov",
            new DateTime(1965,5,20)),
            "Professor", "FIKT", "ZTU");
        array.Add(teacher);

        LibraryUser libraryStudent = new LibraryUser(student, 1);
        array.Add(libraryStudent);

        LibraryUser libraryTeacher = new LibraryUser(teacher, 1);
        array.Add(libraryTeacher);

        LibraryUser libraryUser = new LibraryUser(new Person("Helga", "Lubimova",
            new DateTime(1983, 3, 18)), 2);
        array.Add(libraryUser);

        foreach (object obj in array)
        {
            switch (obj)
            {
                case LibraryUser:
                    var lr = (LibraryUser)obj;
                    lr.ShowInfo();
                    break;
                case Teacher:
                    var tr = (Teacher)obj;
                    tr.ShowInfo();
                    break;
                case Student:
                    var st = (Student)obj;
                    st.ShowInfo();
                    break;
                case Applicant:
                    var app = (Applicant)obj;
                    app.ShowInfo();
                    break;
                case Person:
                    var prsn = (Person)obj;
                    prsn.ShowInfo();
                    break;
            }
        }
       
    }
}