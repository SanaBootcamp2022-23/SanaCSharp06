using System;
using ClassLibrary;
class Release
{


    static public void Main()
    {
        Person person = new Person();
        Applicant applicant = new Applicant();
        LibraryVisitor libraryVisitor = new LibraryVisitor();
        Student student = new Student();
        Teacher teacher = new Teacher();
        person.ShowInfo();
        applicant.ShowInfo();
        libraryVisitor.ShowInfo();
        student.ShowInfo();
        teacher.ShowInfo();
    }
}