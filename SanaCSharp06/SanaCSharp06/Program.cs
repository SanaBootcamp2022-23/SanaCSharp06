using ClassLibrary1;

namespace SanaCSharp06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human ivan = new Human("Ivan", "Ivanov");
            Human ivanna = new Human("Ivanna", "Ivannovna");
            Applicant applicantIvan = new Applicant(200, 7.5f, ivan.Name, ivan.SecondName);
            Applicant applicantIvanna = new Applicant(180, 9, ivanna.Name, ivanna.SecondName);
            Student studentIvanna = new Student(4, "IPZ", "FIKT", "№33", applicantIvanna.ZnoScore, 
                applicantIvanna.EducationScore, ivanna.Name, ivanna.SecondName);
            Teacher anna = new Teacher("Programming Teacher", "Computer Science", "Anna", "Annovna");
            LibraryUser ivannaUser = new LibraryUser(1231254125, new DateTime(2023, 3, 20), ivanna.Name, ivanna.SecondName,
                studentIvanna.Course, studentIvanna.Group, studentIvanna.Faculty, studentIvanna.HigherEducation, studentIvanna.ZnoScore, studentIvanna.EducationScore);
            applicantIvan.ShowInfo();
            anna.ShowInfo();
            ivannaUser.ShowInfo();

        }
    }
}