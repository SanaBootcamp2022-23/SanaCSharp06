using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LibraryUser : Student
    {
        public int ReaderTicketNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double MonthlyReadingFee { get; set; }

        public LibraryUser(int readerTicketNumber, DateTime dateOfIssue, double monthlyReadingFee, string name, string lastName,
            int course, string group, string faculty, string higherEdu, int znoScore, float eduScore) : base(course, group, faculty, higherEdu, znoScore, eduScore, name, lastName)
        {
            ReaderTicketNumber = readerTicketNumber;
            DateOfIssue = dateOfIssue;
            MonthlyReadingFee = monthlyReadingFee;
        }

        public LibraryUser(int readerTicketNumber, DateTime dateOfIssue, string name, string lastName,
            int course, string group, string faculty, string higherEdu, int znoScore, float eduScore) : base(course, group, faculty, higherEdu, znoScore, eduScore, name, lastName)
        {
            ReaderTicketNumber = readerTicketNumber;
            DateOfIssue = dateOfIssue;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Ticket Number {ReaderTicketNumber}");
            Console.WriteLine($"Date of issue {DateOfIssue.ToString()}");
            Console.WriteLine($"Ticket Number {ReaderTicketNumber}");
        }
    }
}
