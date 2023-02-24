namespace OOP2Library
{
    public class LibraryMember : Person
    {
        public long Id { get; }
        public DateTime IssueDate { get; }
        public float MonthlyFee { get; set; }

        public LibraryMember(string firstName, string lastName, DateTime birthday,
            float monthlyFee) : base(firstName, lastName, birthday)
        {
            IssueDate = DateTime.Now;
            Id = IssueDate.ToFileTimeUtc();
            MonthlyFee = monthlyFee;

            _title = "Користувач бібліотеки";
        }
        public LibraryMember(Person person, float monthlyFee)
            : this(person.FirstName, person.LastName, person.Birthday, monthlyFee) { }

        public override string ShowInfo()
        {
            return base.ShowInfo() + 
                $"\n\tНомер квитка: #{Id}" +
                $"\n\tДата видачі: {IssueDate:g}" +
                $"\n\tЩомісячний внесок: {MonthlyFee:F2} грн.";
        }
    }
}
