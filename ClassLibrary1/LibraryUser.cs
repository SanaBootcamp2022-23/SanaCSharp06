namespace ClassLibrary1
{
    public class LibraryUser : Human
    {
        public int Number;
        public DateTime HandOut;
        public int Fee;
        public LibraryUser(string name, string surname, DateTime date, int number, DateTime handout, int fee)
            : base(name, surname, date)
        {
            Number = number;
            HandOut = handout;
            Fee = fee;
        }
        public LibraryUser()
            : base()
        {
            Number = 0;
            HandOut = new DateTime(2023, 1, 1);
            Fee = 0;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер читацького квитка: {Number}");
            Console.WriteLine($"Дата видачі: {HandOut.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Розмір щомісячного читацького внеску: {Fee}");
        }
    }
}