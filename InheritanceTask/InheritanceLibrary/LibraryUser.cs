namespace InheritanceLibrary
{
    sealed public class LibraryUser : Human // Користувач бібліотеки
    {
        // - «Користувач бібліотеки» (номер читацького квитка, дата видачі, розмір щомісячного читацького внеску);
        int ReadersTicketNumber;
        string DateOfIssue;
        double AmountOfMonthlyReadersFee;

        public LibraryUser() : base() // конструктор з параметрами
        {
            ReadersTicketNumber = 0;
            DateOfIssue = "Unknown date of issue";
            AmountOfMonthlyReadersFee = 0;
        }

        public LibraryUser(string name, string surname, int readers_ticket_number, string date_of_issue) : base(name, surname)// конструктор з параметрами
        {
            ReadersTicketNumber = readers_ticket_number;
            DateOfIssue = "He|She|It doesn't know his|her date of issue.";
        }

        public LibraryUser(string name, string surname, string birthday, int readers_ticket_number, string date_of_issue, double amount_of_monthly_readers_fee) : base(name, surname, birthday)// конструктор з параметрами
        {
            ReadersTicketNumber = readers_ticket_number;
            DateOfIssue = date_of_issue;
            AmountOfMonthlyReadersFee = amount_of_monthly_readers_fee;
        }

        public LibraryUser(LibraryUser obj) : base(obj) // конструктор копіювання
        {
            ReadersTicketNumber = obj.ReadersTicketNumber;
            DateOfIssue = obj.DateOfIssue;
            AmountOfMonthlyReadersFee = obj.AmountOfMonthlyReadersFee;
        }

        public void SetReadersTicketNumber(int readers_ticket_number) // сет метод
        {
            if (readers_ticket_number >= 1)
            {
                ReadersTicketNumber = readers_ticket_number;
            }
            else
            {
                ReadersTicketNumber = 0;
                Console.WriteLine("Small|big number of 'readers ticket number' or was entered incorrectly(initialized as 0).");
            }
        }

        public void SetDateOfIssue(string date_of_issue) // сет метод
        {
            if (date_of_issue.Length >= 6)
            {
                DateOfIssue = date_of_issue;
            }
            else
            {
                DateOfIssue = "Incorrect date of issue";
                Console.WriteLine($"Small am. of symb. of 'date of issue' or was entered incorrectly.");
            }
        }

        public void SetAmountOfMonthlyReadersFee(double amount_of_monthly_readers_fee) // сет метод
        {
            if (amount_of_monthly_readers_fee >= 0)
            {
                AmountOfMonthlyReadersFee = amount_of_monthly_readers_fee;
            }
            else
            {
                AmountOfMonthlyReadersFee = 0;
                Console.WriteLine("Small|big number of 'amount of monthly readers fee' or was entered incorrectly(initialized as 0).");
            }
        }

        public int GetReadersTicketNumber() { return ReadersTicketNumber; } // гет метод

        public string GetDateOfIssue() { return DateOfIssue; } // гет метод

        public double GetAmountOfMonthlyReadersFee() { return AmountOfMonthlyReadersFee; } // гет метод

        public override void ShowInfo() // перевизначений метод 
        {
            Console.WriteLine("\nInformation about class 'LibraryUser': ");
            base.ShowInfo();
            Console.WriteLine($"Readers ticket number: {ReadersTicketNumber,-10}");
            Console.WriteLine($"Date of issue: {DateOfIssue,-10}");
            Console.WriteLine($"Amount of monthly readers fee: {AmountOfMonthlyReadersFee,-10}");
        }
    }
}
