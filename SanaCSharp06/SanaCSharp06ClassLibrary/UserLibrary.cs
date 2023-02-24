namespace SanaCSharp06ClassLibrary;

public class UserLibrary : Human
{
    //Дата видачі
    protected Date DateOfIssue { get; set; }

    //Розмір щомісячного читацького внеску
    private double readerFee;
    protected double ReaderFee
    {
        get => readerFee;
        
        set => readerFee = value switch
        {
            < 0 => 0,
            > 1000 => 1000,
            _ => value
        };
    }

    //Номер читацького квитка
    protected string ReaderTicket { get; set; } 

    //Конструктор по замовчуванню
    public UserLibrary()
    {
        ReaderTicket = "ІВ-45678АЗ87";
        DateOfIssue = new Date(2023, 2, 17);
        ReaderFee = 120.5;
    }

    //Два конструктори з параметрами
    public UserLibrary(string name, string surname, Date dateOfBirthday, string readerTicket, Date dateOfIssue,
        double readerFee) : base(name, surname, dateOfBirthday)
    {
        ReaderTicket = readerTicket;
        DateOfIssue = dateOfIssue;
        ReaderFee = readerFee;
    }

    public UserLibrary(string name, string surname, Date dateOfBirthday, string readerTicket, Date dateOfIssue) : base(
        name, surname, dateOfBirthday)
    {
        ReaderTicket = readerTicket;
        DateOfIssue = dateOfIssue;
        ReaderFee = 120.5;
    }

    //Конструктор копіювання
    public UserLibrary(UserLibrary userLibrary)
    {
        ReaderTicket = userLibrary.ReaderTicket;
        DateOfIssue = userLibrary.DateOfIssue;
        ReaderFee = userLibrary.ReaderFee;
    }

    //Віртуальний метод, який виводить усю доступну інформацію
    public override string ShowInfo()
    {
        return $"Ім'я: {Name}\n" +
               $"Прізвище: {Surname}\n" +
               $"Дата народження: {DateOfBirthday.ToStringDateShort()}\n" +
               $"Номер читацького квитка: {ReaderTicket}\n" +
               $"Дата видачі: {DateOfIssue.ToStringDate()}\n" +
               $"Щомісячний внесок: {ReaderFee}";
    }
}