using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06_ClassLibrary
{
    public class LibraryUser : Person
    {
        private double _libraryFee;
        public uint LibraryTicketID { get; set; }
        public DateTime IssueDate { get; set; } = default;
        public double LibraryFee
        {
            get { return _libraryFee; }
            set { if (value > 0 && value < 200) _libraryFee = value; }
        }

        public LibraryUser(string firstName, string lastName, DateTime birthDate, uint libraryTicketID, DateTime issueDate)
            : base(firstName, lastName, birthDate)
        {
            LibraryTicketID = libraryTicketID;
            IssueDate = issueDate;
        }

        public LibraryUser(string firstName, string lastName, DateTime birthDate, uint libraryTicketID, DateTime issueDate, double libraryFee)
            : this(firstName, lastName, birthDate, libraryTicketID, issueDate)
        {
            LibraryFee = libraryFee;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine($"Library ticket ID: #{LibraryTicketID}");
            Console.WriteLine($"Ticket issue date: {IssueDate.ToShortDateString()}");
            Console.WriteLine($"Monthly library fee: {_libraryFee}");
        }
    }
}
