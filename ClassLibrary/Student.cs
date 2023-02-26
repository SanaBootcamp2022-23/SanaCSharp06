using ClassLibrary;

public class Student : People
{
    protected int Course;
    protected string Group;
    protected string Faculty;
    protected string StudingPlaceName;
    public Student(int Course, string Group, string Faculty, string StudingPlaceName, string Name,
        string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
    {
        this.Course = Course;
        this.Group = Group;
        this.Faculty = Faculty;
        this.StudingPlaceName = StudingPlaceName;
    }
    public Student(int Course, string Group, string Faculty, string Name,
        string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
    {
        this.Course = Course;
        this.Group = Group;
        this.Faculty = Faculty;
        this.StudingPlaceName = "Державний університет";
    }
    public Student(int Course, string Group, string Name,
        string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
    {
        this.Course = Course;
        this.Group = Group;
        this.Faculty = "ФІКТ";
        this.StudingPlaceName = "Державний університет";
    }
    public Student(int Course, string Name,
        string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
    {
        this.Course = Course;
        this.Group = "ІПЗ";
        this.Faculty = "ФІКТ";
        this.StudingPlaceName = "Державний університет";
    }
    public Student() : base()
    {
        this.Course = 2;
        this.Group = "ІПЗ";
        this.Faculty = "ФІКТ";
        this.StudingPlaceName = "Державний університет";
    }
    public int course
    {
        set { if (value > 0 && value <= 4) Course = value; }
        get { return Course; }
    }
    public string group
    {
        set { if (value.Length > 0) Group = value; }
        get { return Group; }
    }
    public string faculty
    {
        set { if (value.Length > 0) Faculty = value; }
        get { return Faculty; }
    }
    public string studingPlaceName
    {
        set { if (value.Length > 0) StudingPlaceName = value; }
        get { return StudingPlaceName; }
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Курс: {Course}");
        Console.WriteLine($"Группа: {Group}");
        Console.WriteLine($"Факультет: {Faculty}");
        Console.WriteLine($"Назва вищого навчального закладу: {StudingPlaceName}");
    }
}
