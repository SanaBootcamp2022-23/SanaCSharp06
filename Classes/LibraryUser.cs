using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class LibraryUser : Human
    {
        protected string TicketNumber;
        protected string IssueDate;
        protected string MonthlyContSize;

        public LibraryUser()
        {
            Name = "Name";
            Surname = "Surname";
            Birthday = "Birthday";
            TicketNumber = "TicketNumber";
            IssueDate = "IssueDate";
            MonthlyContSize = "MonthlyContSize";
        }

        public LibraryUser(string name, string surname, string birthday, string ticketNumber, string issueDate, string monthlyContSize)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            TicketNumber = ticketNumber;
            IssueDate = issueDate;
            MonthlyContSize = monthlyContSize;
        }

        public LibraryUser(LibraryUser obj)
        {
            Name = obj.Name;
            Surname = obj.Surname;
            Birthday = obj.Birthday;
            TicketNumber = obj.TicketNumber;
            IssueDate = obj.IssueDate;
            MonthlyContSize = obj.MonthlyContSize;
        }

        public string GetTicketNumber()
        {
            return TicketNumber;
        }

        public string GetIssueDate()
        {
            return IssueDate;
        }

        public string GetMonthlyContSize()
        {
            return MonthlyContSize;
        }

        public void SetTicketNumber(string ticketNumber)
        {
            TicketNumber = ticketNumber;
        }

        public void SetIssueDate(string issueDate)
        {
            IssueDate = issueDate;
        }

        public void SetMonthlyContSize(string monthlyContSize)
        {
            MonthlyContSize = monthlyContSize;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Користувач бібліотеки.");
            Console.WriteLine($" Номер читацького квитка: {TicketNumber}");
            Console.WriteLine($" Дата видачі: {IssueDate}");
            Console.WriteLine($" Розмір щомісячного читацького внеску: {MonthlyContSize}");
        }
    }
}
