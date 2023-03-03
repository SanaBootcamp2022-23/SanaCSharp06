using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class LibraryUser : Person
    {
        int ReaderTicketNumber { get; set; }
        string DateOfIssue { get; set; }
        decimal ContributionAmount { get; set; }
        public LibraryUser(string firstName, string lastName,  string birthDate, 
            int readerTicketNumber, string dateOfIssue, decimal contributionAmount) : base (firstName, lastName, birthDate)
        {
            ReaderTicketNumber = readerTicketNumber;
            DateOfIssue = dateOfIssue;
            ContributionAmount = contributionAmount;
        }

        public LibraryUser()
        {

        }

        public LibraryUser(string firstName, string lastName, 
            int readerTicketNumber, decimal contributionAmount) : base (firstName, lastName)
        {
            ReaderTicketNumber = readerTicketNumber;
            ContributionAmount = contributionAmount;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ReaderTicketNumber: {ReaderTicketNumber}\n" +
                $"DateOfIssue: {DateOfIssue}\n" +
                $"ContributionAmount: {ContributionAmount}\n");
        }
    }
}
