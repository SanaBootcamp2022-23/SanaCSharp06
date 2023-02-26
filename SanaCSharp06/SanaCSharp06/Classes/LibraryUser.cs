using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06.Classes
{
    public class LibraryUser : Person
    {
        public uint ReaderId { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double MonthFee { get; set; }
        public LibraryUser(string firstName, string lastName, DateTime birthDate, uint readerId, DateTime dateOfIssue,
            double monthFee) : base(firstName, lastName, birthDate)
        {
            ReaderId = readerId;
            DateOfIssue = dateOfIssue;
            MonthFee = monthFee;
        }
        public LibraryUser(string firstName, string lastName, DateTime birthDate, uint readerId, DateTime dateOfIssue) : base(firstName, lastName, birthDate)
        {
            ReaderId = readerId;
            DateOfIssue = dateOfIssue;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {FirstName},\nLast name: {LastName},\nBirthday: {BirthDate},\n" +
                $"Id: {ReaderId},\nDate of issue: {DateOfIssue},\nMonthFee: {MonthFee}");
            Console.WriteLine();
        }
    }
}
