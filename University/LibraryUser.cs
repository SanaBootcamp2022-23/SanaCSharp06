namespace University
{
    public class LibraryUser : Person
    {
        public uint NumberReaderTicket { get; set; }
        public DateTime DateOfIssue { get; set; }
        public uint MonthlyFee { get; set; }

        public LibraryUser() { }
        public LibraryUser(string name, string surname, DateTime dateOfBirth, uint numberReaderTicket, DateTime dateOfIssue, uint monthlyFee) : base(name, surname, dateOfBirth)
        {
            NumberReaderTicket = numberReaderTicket;
            DateOfIssue = dateOfIssue;
            MonthlyFee = monthlyFee;
        }
        public LibraryUser(string name, string surname, uint numberReaderTicket, DateTime dateOfIssue, uint monthlyFee) : this(name, surname, new DateTime(), numberReaderTicket, dateOfIssue, monthlyFee)
        { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Number of reader ticket: {NumberReaderTicket}\n" +
                $"Date of issue: {DateOfIssue.ToShortDateString()}\nMonthly fee: {MonthlyFee}");
        }
    }
}
