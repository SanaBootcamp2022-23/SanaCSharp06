namespace UniversityLibrary;

public class Student : Person
{
    private int _course;
    private string _group;
    private string _faculty;
    private string _higherEducationInstitution;

    public Student(string name, string surname, int course, string group, string faculty, string higherEducationInstitution) 
        : base(name, surname)
    {
        Course = course;
        Group = group;
        Faculty = faculty;
        HigherEducationInstitution = higherEducationInstitution;
    }

    public Student(string name, string surname, DateTime dateOfBirth, int course, string group, string faculty, string higherEducationInstitution) 
        : base(name, surname, dateOfBirth)
    {
        Course = course;
        Group = group;
        Faculty = faculty;
        HigherEducationInstitution = higherEducationInstitution;
    }

    public Student(Person person, int course, string group, string faculty, string higherEducationInstitution) 
        : base(person)
    {
        Course = course;
        Group = group;
        Faculty = faculty;
        HigherEducationInstitution = higherEducationInstitution;
    }

    public int Course 
    { 
        get => _course;
        set
        {
            if (value < 1 || value > 6)
                throw new ArgumentException("Курс не може бути менше 1 і більше 6");
            _course = value;
        }
    }
    public string Group 
    {
        get => _group;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Назва групи не може бути пустою");
            _group = value;
        }
    }
    public string Faculty
    {
        get => _faculty;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Назва факультету не може бути пустою");
            _faculty = value;
        }
    }
    public string HigherEducationInstitution {
        get => _higherEducationInstitution;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Назва університету не може бути пустою");
            _higherEducationInstitution = value;
        }
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Курс: {Course}\nГрупа: {Group}\nФакультет: {Faculty}\n" +
                          $"Вищий навчальний заклад: {HigherEducationInstitution}\n");
    }
}