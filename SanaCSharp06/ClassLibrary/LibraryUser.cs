namespace ClassLibrary
{
	public class LibraryUser : Person
	{
		public int readerTicketNumber;
		public DateTime dateIssuance;
		public decimal costForMonth;

		public LibraryUser() { }
		public LibraryUser(int readerTicketNumber, DateTime dateIssuance, decimal costForMonth)
		{
			this.readerTicketNumber = readerTicketNumber;
			this.dateIssuance = dateIssuance;
			this.costForMonth = costForMonth;
		}
		public LibraryUser(int readerTicketNumber, DateTime dateIssuance, decimal costForMonth, Person person) : this(readerTicketNumber, dateIssuance, costForMonth)
		{
			this.firstName = person.firstName;
			this.secondName = person.secondName;
			this.dateOfBirth = person.dateOfBirth;
		}
		public LibraryUser(LibraryUser libraryUser)
		{
			this.firstName = libraryUser.firstName;
			this.secondName = libraryUser.secondName;
			this.dateOfBirth = libraryUser.dateOfBirth;
			this.readerTicketNumber= libraryUser.readerTicketNumber;
			this.dateIssuance= libraryUser.dateIssuance;
			this.costForMonth= libraryUser.costForMonth;
		}

		public void SetReaderTicketNumber(int readerTicketNumber) => this.readerTicketNumber = readerTicketNumber;
		public int GetReaderTicketNumber() => this.readerTicketNumber;

		public void SetDateIssuance(DateTime dateIssuance) => this.dateIssuance = dateIssuance;
		public DateTime GetDateTime() => this.dateIssuance;

		public void SetCostForMonth(decimal costForMonth) => this.costForMonth = costForMonth;
		public decimal GetCostForMonth() => this.costForMonth;

		public override void ShowInfo()
		{
			base.ShowInfo();
			Console.WriteLine($"id квитка: {readerTicketNumber}, дата видачі: {dateIssuance.ToString("yyyy/MM/dd")}, ціна = {costForMonth}");
		}
	}
}
