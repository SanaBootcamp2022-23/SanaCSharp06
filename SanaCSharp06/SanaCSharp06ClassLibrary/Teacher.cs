namespace SanaCSharp06ClassLibrary;

public class Teacher : Human
{
    protected string Department { get; set; } //Кафедра
    protected string Position { get; set; } //Посада
    protected string University { get; set; } //Вищий навчальний заклад

    //Конструктор по замовчуванню
    public Teacher()
    {
        Position = "Декан";
        Department = "ІПЗ";
        University = "Житомирська політехніка";
    }

    //Два конструктори з параметрами
    public Teacher(string name, string surname, Date dateOfBirthday, string position, string department,
        string university) : base(name, surname, dateOfBirthday)
    {
        Position = position;
        Department = department;
        University = university;
    }

    public Teacher(string name, string surname, Date dateOfBirthday, string position, string department) : base(name,
        surname, dateOfBirthday)
    {
        Position = position;
        Department = department;
        University = "Житомирська політехніка";
    }

    //Конструктор копіювання
    public Teacher(Teacher teacher)
    {
        Position = teacher.Position;
        Department = teacher.Department;
        University = teacher.University;
    }

    //Віртуальний метод, який виводить усю доступну інформацію
    public override string ShowInfo()
    {
        return $"Ім'я: {Name}\n" +
               $"Прізвище: {Surname}\n" +
               $"Дата народження: {DateOfBirthday.ToStringDateShort()}\n" +
               $"Посада: {Position}\n" +
               $"Кафедра {Department}\n" +
               $"ЗВО: {University}";
    }
}