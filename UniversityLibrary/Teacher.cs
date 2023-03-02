namespace UniversityLibrary;

public class Teacher : Person
{
    private string _position;
    private string _department;
    private string _higherEducationInstitution;
    
    public Teacher(string name, string surname, string position, string department, 
        string higherEducationInstitution) : base(name, surname)
    {
        Position = position;
        Department = department;
        HigherEducationInstitution = higherEducationInstitution;
    }

    public Teacher(string name, string surname, DateTime dateOfBirth, string position, 
        string department, string higherEducationInstitution) : base(name, surname, dateOfBirth)
    {
        Position = position;
        Department = department;
        HigherEducationInstitution = higherEducationInstitution;
    }

    public Teacher(Person person, string position, string department, 
        string higherEducationInstitution) : base(person)
    {
        Position = position;
        Department = department;
        HigherEducationInstitution = higherEducationInstitution;
    }

    public string Position 
    {
        get => _position;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Посада не може бути пустою");
            _position = value;
        }
    }
    public string Department 
    {
        get => _department;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Кафедра не може бути пустою");
            _department = value;
        }
    }
    public string HigherEducationInstitution 
    {
        get => _higherEducationInstitution;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Назва навчального закладу не може бути пустою");
            _higherEducationInstitution = value;
        }
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Посада: {Position}\nКафедра: {Department}\n" +
                          $"Вищий навчальний заклад: {HigherEducationInstitution}");
    }
}