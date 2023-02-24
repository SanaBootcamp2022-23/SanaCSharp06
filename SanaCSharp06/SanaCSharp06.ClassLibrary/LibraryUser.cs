namespace SanaCSharp06.ClassLibrary
{
    public class LibraryUser : Person
    {
        public string LibraryCardNumber { get; set; }
        public DateTime DateOfIssue { get; set; } = default;
        public ushort MonthlyReadershipFee { get; set; }

        public LibraryUser(string name, string surname, DateTime dateOfBirth, string libraryCardNumber, DateTime dateOfIssue, ushort monthlyReadershipFee) : base(name, surname, dateOfBirth)
        {
            LibraryCardNumber = libraryCardNumber;
            MonthlyReadershipFee = monthlyReadershipFee;
            DateOfIssue = dateOfIssue;
        }
        
        public LibraryUser(string name, string surname, DateTime dateOfBirth, string libraryCardNumber, ushort monthlyReadershipFee) : base(name, surname, dateOfBirth)
        {
            LibraryCardNumber = libraryCardNumber;
            MonthlyReadershipFee = monthlyReadershipFee;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Номер читацького квитка: {LibraryCardNumber};\nРозмір щомісячного читацького внеску: {MonthlyReadershipFee} гривень";
            info += DateOfIssue == default ? "" : $"\nДата видачі: {DateOfIssue.Day}.{DateOfIssue.Month}.{DateOfIssue.Year};";
            Console.WriteLine(info);
        }
    }
}