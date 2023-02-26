using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class LibraryUser : Person
    {
        public int Ticket { get; set; }
        public DateTime IssueDate { get; set; }
        public decimal Payment { get; set; }
        public LibraryUser()
        {
            Ticket = 0;
            IssueDate = DateTime.MinValue;
            Payment = 0;
        }
        public LibraryUser(string Name, string SurName, int Ticket) : base(Name, SurName)
        {
            this.Ticket = Ticket;
            IssueDate = DateTime.MinValue;
            Payment = 0;
        }
        public LibraryUser(string Name, string SurName, DateTime Birthday, int Ticket, DateTime IssueDate, decimal Payment) : base(Name, SurName, Birthday)
        {
            this.Ticket = Ticket;
            this.IssueDate = IssueDate;
            this.Payment = Payment;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Ticket number: {Ticket}\nDate of issue: {IssueDate.ToShortDateString()}\nPayment: {Payment}");
        }
    }
}
