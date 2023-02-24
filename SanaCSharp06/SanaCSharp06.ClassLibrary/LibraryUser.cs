namespace SanaCSharp06.ClassLibrary
{
    public class LibraryUser : Person
    {
        public string LibraryCardNumber { get; set; }
        public DateTime DateOfIssue { get; set; } = default;
        public ushort MonthlyReadershipFee { get; set; }

        public LibraryUser(string libraryCardNumber, DateTime dateOfIssue, ushort monthlyReadershipFee) : this(libraryCardNumber, monthlyReadershipFee)
        {
            DateOfIssue = dateOfIssue;
        }
        
        public LibraryUser(string libraryCardNumber, ushort monthlyReadershipFee)
        {
            LibraryCardNumber = libraryCardNumber;
            MonthlyReadershipFee = monthlyReadershipFee;
        }
        public LibraryUser() { }
        
        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Номер читацького квитка: {LibraryCardNumber};\nРозмір щомісячного читацького внеску: {MonthlyReadershipFee} гривень";
            info += DateOfIssue == default ? "" : $"\nДата видачі: {DateOfIssue.Day}.{DateOfIssue.Month}.{DateOfIssue.Year};";
            Console.WriteLine(info);
        }
    }
}