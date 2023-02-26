namespace ClassLibrary
{
    public class LibraryUser : People
    {
        protected string ReadingNumber;
        protected string Date;
        protected float Payment;
        public LibraryUser(string ReadingNumber, string Date, int Payment, string Name,
            string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
        {
            this.ReadingNumber = ReadingNumber;
            this.Date = Date;
            this.Payment = Payment;
        }
        public LibraryUser(string ReadingNumber, string Date, string Name,
            string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
        {
            this.ReadingNumber = ReadingNumber;
            this.Date = Date;
            this.Payment = 100;
        }
        public LibraryUser(string ReadingNumber, string Name,
            string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
        {
            this.ReadingNumber = ReadingNumber;
            this.Date = "01.01.2020";
            this.Payment = 100;
        }
        public LibraryUser() : base()
        {
            this.ReadingNumber = "0000";
            this.Date = "01.01.2020";
            this.Payment = 100;
        }
        public string readingNumber
        {
            set { if (value.Length > 0) ReadingNumber = value; }
            get { return ReadingNumber; }
        }
        public string date
        {
            set { if (value.Length > 0) Date = value; }
            get { return Date; }
        }
        public float payment
        {
            set { if (value > 0) Payment = value; }
            get { return Payment; }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер читацького квитка: {ReadingNumber}");
            Console.WriteLine($"Дата видачі: {Date}");
            Console.WriteLine($"Розмір щомісячного читацького внеску: {Payment}");
        }
    }

}
