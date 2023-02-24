namespace SanaCSharp06ClassLibrary;

public class Entrant : Human
{
    //Кількість балів за документ про освіту
    private double schoolMark;

    protected double SchoolMark
    {
        get => schoolMark;
        
        set => schoolMark = value switch 
        {
            <= 0 => 1,
            > 12 => 12,
            _ => value
        };
    }

    //Назва загальноосвітнього навчального закладу
    protected string SchoolName { get; set; }

    //Кількість балів сертифікатів ЗНО
    private double znoMark;
    protected double ZnoMark
    {
        get => znoMark;

        set => znoMark = value switch
        {
            < 100 => 0,
            > 200 => 200,
            _ => value
        };
    }

    //Конструктор по замовчуванню
    public Entrant()
    {
        ZnoMark = 200;
        SchoolMark = 12;
        SchoolName = "Олевська ЗОШ №3";
    }

    //Два конструктори з параметрами
    public Entrant(string name, string surname, Date dateOfBirthday, double znoMark, double schoolMark,
        string schoolName) : base(name, surname, dateOfBirthday)
    {
        ZnoMark = znoMark;
        SchoolMark = schoolMark;
        SchoolName = schoolName;
    }

    public Entrant(string name, string surname, Date dateOfBirthday, double znoMark, double schoolMark) : base(name,
        surname, dateOfBirthday)
    {
        ZnoMark = znoMark;
        SchoolMark = schoolMark;
        SchoolName = "Олевська ЗОШ №3";
    }

    //Конструктор копіювання
    public Entrant(Entrant entrant)
    {
        ZnoMark = entrant.ZnoMark;
        SchoolMark = entrant.SchoolMark;
        SchoolName = entrant.SchoolName;
    }

    //Віртуальний метод, який виводить усю доступну інформацію
    public override string ShowInfo()
    {
        return $"Ім'я: {Name}\n" +
               $"Прізвище: {Surname}\n" +
               $"Дата народження: {DateOfBirthday.ToStringDateShort()}\n" +
               $"Бал ЗНО: {ZnoMark}\n" +
               $"Шкільний бал: {SchoolMark}\n" +
               $"Назва загальноосвітнього закладу: {SchoolName}";
    }
}