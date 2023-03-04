using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        public string TicketNumber { get; set; } 
        public DateTime DateOfIssue { get; set; } 
        public uint MonthlyPayment { get; set; } 

        public LibraryUser(string firstName, string lastName, DateTime date, string tiket, DateTime dateOfIssue, uint monthlyPayment) 
            : base( firstName,  lastName,  date)
        {
            TicketNumber = tiket;
            MonthlyPayment = monthlyPayment;
            DateOfIssue = dateOfIssue;
        }
        public override string ShowInfo()
        {
            return $"Class LibraryUser => {FirstName} {LastName} {Date.Year}-{Date.Month}-{Date.Day} TicketNumber:{TicketNumber} DateOfIssue:{DateOfIssue} MonthlyPayment: {MonthlyPayment} ";
        }
    }
}
