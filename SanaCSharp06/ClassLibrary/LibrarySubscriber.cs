using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibrarySubscriber : Person
    {
        public int ReaderTicketNumber { get; set; }
        public string IssueDate { get; set; } 
        public double MonthlyPayment { get; set; } 
        public LibrarySubscriber(string name, string surname, string birthday, int readerTicketNumber, string issueDate, double monthlyPayment)
            : base(name, surname, birthday)
        {
            ReaderTicketNumber = readerTicketNumber;
            IssueDate = issueDate;
            MonthlyPayment = monthlyPayment;
        }
        public LibrarySubscriber(string name, string surname, string birthday, string issueDate, double monthlyPayment)
            : base(name, surname, birthday)
        {
            ReaderTicketNumber = 233;
            IssueDate = issueDate;
            MonthlyPayment = monthlyPayment;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер читацького квитка: #{ReaderTicketNumber}");
            Console.WriteLine($"Дата видачі: {IssueDate}");
            Console.WriteLine($"Щомісячний читацький внесок: {MonthlyPayment}UAH");
        }
    }
}
