namespace UniversityLibrary;

public class Person
{
    private string _name;
    private string _surname;

    protected Person()
    {
        _name = "name";
        _surname = "surname";
        DateOfBirth = DateTime.MinValue;
    }

    protected Person(string name, string surname)
    {
        Name = name;
        Surname = surname;
        DateOfBirth = DateTime.MinValue;
    }

    protected Person(string name, string surname, DateTime dateOfBirth)
    {
        Name = name;
        Surname = surname;
        DateOfBirth = dateOfBirth;
    }

    protected Person(Person person)
    {
        _name = person.Name;
        _surname = person.Surname;
        DateOfBirth = person.DateOfBirth;
    }
    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Імʼя не може бути пустим");
            _name = value;
        }
    }
    public string Surname 
    {
        get => _surname;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Прізвище не може бути пустим");
            _surname = value;
        }
    }
    public DateTime DateOfBirth { get; set; }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Імʼя: {Name}\nПрізвище: {Surname}\nДата народження: {DateOfBirth.ToShortDateString()}");
    }
}