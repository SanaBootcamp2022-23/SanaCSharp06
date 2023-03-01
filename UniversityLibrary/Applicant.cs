namespace UniversityLibrary;

public class Applicant : Person
{
    private double _externalExamPoints;
    private double _educationDocPoints;
    private string _schoolName;
    
    public Applicant(string name, string surname, double externalExamPoints, double educationDocPoints,
        string schoolName) : base(name, surname)
    {
        ExternalExamPoints = externalExamPoints;
        EducationDocPoints = educationDocPoints;
        SchoolName = schoolName;
    }

    public Applicant(string name, string surname, DateTime dateOfBirth, double externalExamPoints,
        double educationDocPoints, string schoolName) : base(name, surname, dateOfBirth)
    {
        ExternalExamPoints = externalExamPoints;
        EducationDocPoints = educationDocPoints;
        SchoolName = schoolName;
    }

    public Applicant(Person person, double externalExamPoints, double educationDocPoints, string schoolName) :
        base(person)
    {
        ExternalExamPoints = externalExamPoints;
        EducationDocPoints = educationDocPoints;
        SchoolName = schoolName;
    }

    public double ExternalExamPoints
    {
        get => _externalExamPoints;
        set
        {
            if (value < 100 || value > 200)
                throw new ArgumentException("Бал зно не може бути більше 200 або менше 100");
            _externalExamPoints = value;
        }
    }
    public double EducationDocPoints
    {
        get => _educationDocPoints;
        set
        {
            if (value > 12)
                throw new ArgumentException("Кількість балів за документ про освіту не може бути більше 12");
            _educationDocPoints = value;
        }
    }
    public string SchoolName
    {
        get => _schoolName;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Назва школи не може бути пустою");
            _schoolName = value;
        }
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Кількість балів сертифікатів ЗНО: {ExternalExamPoints}\nКількість балів за документ про освіту: {EducationDocPoints}\n" +
                          $"Назва загальноосвітнього навчального закладу: {SchoolName}\n");
    }
}