namespace ClassLibrary1
{
    public class LibraryUser : Person
    {
        protected int TicketNumber { get; set; }
        protected string DateOfIssue { get; set; }
        protected double Price { get; set; }

        public LibraryUser(string firstName, string lastName, string dateOfBirth, int ticketNumber,
            string dateOfIssue, double price) : base(firstName, lastName, dateOfBirth)
        {
            TicketNumber = ticketNumber;
            DateOfIssue = dateOfIssue;
            Price = price;
        }
        
        public LibraryUser(string firstName, string lastName, int ticketNumber)
            : base(firstName, lastName)
        {
            TicketNumber = ticketNumber;
        }

        public override string ShowInfo()
        {
            return $"{FirstName} {LastName} {DateOfBirth} {TicketNumber} {DateOfIssue} {Price}";
        }
    }
}