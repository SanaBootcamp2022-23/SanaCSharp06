namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        public uint ReaderTicketNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double MonthlyReaderFee { get; set; }
        public LibraryUser(string firstName, string lastName, DateTime birthDate,
            uint readerTicketNumber, DateTime dateOfIssue, double monthlyReaderFee) : 
            base(firstName, lastName, birthDate)
        {
            ReaderTicketNumber = readerTicketNumber;
            DateOfIssue = dateOfIssue;
            MonthlyReaderFee = monthlyReaderFee;
        }
        public LibraryUser(string firstName, string lastName,
            uint readerTicketNumber, DateTime dateOfIssue, double monthlyReaderFee) : 
            base(firstName, lastName)
        {
            ReaderTicketNumber = readerTicketNumber;
            DateOfIssue = dateOfIssue;
            MonthlyReaderFee = monthlyReaderFee;
        }
        public LibraryUser() { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Номер читацького квитка: {ReaderTicketNumber};" +
                $"\nДата видачі: {DateOfIssue.Day}.{DateOfIssue.Month}.{DateOfIssue.Year};" +
                $"\nРозмір щомісячного читацького внеску: {MonthlyReaderFee} грн";
            Console.WriteLine(info);
        }
    }
}
