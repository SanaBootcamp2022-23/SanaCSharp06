namespace SanaCSharp06ClassLibrary;

public class Student : Human
{
    //Курс 
    private int course;
    protected int Course
    {
        get => course;
        
        set => course = value switch
        {
            < 1 => 1,
            > 7 => 7,
            _ => value
        };
    }

    protected string Faculty { get; set; } //Факультет 
    protected string Group { get; set; } //Група
    protected string University { get; set; } //Вищий навчальний заклад

    //Конструктор копіювання
    public Student()
    {
        Course = 1;
        Group = "ІПЗ-20-2";
        Faculty = "ФІКТ";
        University = "Житомирська політехніка";
    }

    //Два конструктори з параметрами
    public Student(string name, string surname, Date dateOfBirthday, int course, string group, string faculty,
        string university) : base(name, surname, dateOfBirthday)
    {
        Course = course;
        Group = group;
        Faculty = faculty;
        University = university;
    }

    public Student(string name, string surname, Date dateOfBirthday, int course, string group, string faculty) : base(
        name, surname, dateOfBirthday)
    {
        Course = course;
        Group = group;
        Faculty = faculty;
        University = "Житомирська політехніка";
    }

    //Конструктор копіювання
    public Student(Student student)
    {
        Course = student.Course;
        Group = student.Group;
        Faculty = student.Faculty;
    }

    //Віртуальний метод, який виводить усю доступну інформацію
    public override string ShowInfo()
    {
        return $"Ім'я: {Name}\n" +
               $"Прізвище: {Surname}\n" +
               $"Дата народження: {DateOfBirthday.ToStringDateShort()}\n" +
               $"Курс: {Course}\n" +
               $"Група: {Group}\n" +
               $"Факультет: {Faculty}\n" +
               $"ЗВО: {University}";
    }
}