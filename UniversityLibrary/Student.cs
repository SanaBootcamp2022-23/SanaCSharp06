namespace UniversityLibrary;

public class Student : Applicant
{
    private int _course;
    private string _group;
    private string _faculty;
    private string _higherEducationInstitution;

    public Student()
    {
        _course = 0;
        _group = "unknown";
        _faculty = "unknown";
        _higherEducationInstitution = "unknown";
    }
    public Student(string name, string surname, double externalExamPoints, double educationDocPoints,
        string schoolName, int course, string group, string faculty, string higherEducationInstitution) 
        : base(name, surname, externalExamPoints, educationDocPoints,
            schoolName)
    {
        Course = course;
        Group = group;
        Faculty = faculty;
        HigherEducationInstitution = higherEducationInstitution;
    }

    public Student(string name, string surname, DateTime dateOfBirth, double externalExamPoints,
        double educationDocPoints, string schoolName, int course, string group, 
        string faculty, string higherEducationInstitution) 
        : base(name, surname, dateOfBirth, externalExamPoints, educationDocPoints, schoolName)
    {
        Course = course;
        Group = group;
        Faculty = faculty;
        HigherEducationInstitution = higherEducationInstitution;
    }

    public Student(Person person, double externalExamPoints, double educationDocPoints, string schoolName, 
        int course, string group, string faculty, string higherEducationInstitution) 
        : base(person, externalExamPoints, educationDocPoints, schoolName)
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
                          $"Вищий навчальний заклад: {HigherEducationInstitution}");
    }
}