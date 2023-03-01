public class LibraryUser
{
    public int CardNumber { get; set; }
    public DateTime IssueDate { get; set; }
    public decimal MonthlyFee { get; set; }

    public LibraryUser(int cardNumber, DateTime issueDate, decimal monthlyFee)
    {
        CardNumber = cardNumber;
        IssueDate = issueDate;
        MonthlyFee = monthlyFee;
    }

    public LibraryUser( DateTime issueDate, decimal monthlyFee)
    {
        CardNumber = 1;
        IssueDate = issueDate;
        MonthlyFee = monthlyFee;
    }

    public LibraryUser()
    {
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Card Number: {CardNumber}");
        Console.WriteLine($"Issue Date: {IssueDate.ToShortDateString()}");
        Console.WriteLine($"Monthly Fee: {MonthlyFee}");
    }
}
