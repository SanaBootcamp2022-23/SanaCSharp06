using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClass
{
    public class LibraryUser : Person
    {
        public int ReaderTicketNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal MonthlyFee { get; set; }

        public LibraryUser(string firstname, string lastname, DateTime dateOfBirth, int readerTicketNumber, DateTime issueDate, decimal monthlyFee)
            : base(firstname, lastname, dateOfBirth)
        {
            ReaderTicketNumber = readerTicketNumber;
            IssueDate = issueDate;
            MonthlyFee = monthlyFee;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Reader Ticket Number: {ReaderTicketNumber}\nIssue Book Date: {IssueDate}\nMonthly Reader Fee: {MonthlyFee}");
        }
    }
}
