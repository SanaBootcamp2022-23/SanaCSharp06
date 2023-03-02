namespace UniversityLibrary;

public class LibraryUser : Person
{
    private int _readerTicketNumber;
    private decimal _monthlyFee;
    private DateTime _issueDate;

    public LibraryUser()
    {
        _readerTicketNumber = 0;
        _monthlyFee = 0;
        _issueDate = DateTime.MinValue;
    }
    public LibraryUser(string name, string surname, int readerTicketNumber, decimal monthlyFee, 
        DateTime issueDate) : base(name, surname)
    {
        _readerTicketNumber = readerTicketNumber;
        _monthlyFee = monthlyFee;
        _issueDate = issueDate;
    }

    public LibraryUser(string name, string surname, DateTime dateOfBirth, int readerTicketNumber, 
        decimal monthlyFee, DateTime issueDate) : base(name, surname, dateOfBirth)
    {
        _readerTicketNumber = readerTicketNumber;
        _monthlyFee = monthlyFee;
        _issueDate = issueDate;
    }

    public LibraryUser(Person person, int readerTicketNumber, decimal monthlyFee, 
        DateTime issueDate) : base(person)
    {
        _readerTicketNumber = readerTicketNumber;
        _monthlyFee = monthlyFee;
        _issueDate = issueDate;
    }

    public int ReaderTicketNumber 
    { 
        get => _readerTicketNumber;
        set
        {
            if (value < 1)
                throw new ArgumentException("Номер читацького квитка не може бути менше 1");
            _readerTicketNumber = value;
        }
    }
    public DateTime IssueDate 
    {
        get => _issueDate;
        set
        {
            if (value < base.DateOfBirth)
                throw new ArgumentException("Дата видачі не може бути меншою за дату народження");
            _issueDate = value;
        }
    }
    public decimal MonthlyFee
    {
        get => _monthlyFee;
        set
        {
            if (value < 0)
                throw new ArgumentException("Розмір щомісячного читацького внеску не може бути відʼємним");
            _monthlyFee = value;
        }
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Номер читацького квитка: {ReaderTicketNumber}\nДата видачі: {IssueDate}\n" +
                          $"Розмір щомісячного читацького внеску: {MonthlyFee} грн.");
    }
}