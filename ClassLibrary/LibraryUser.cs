using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        public string CardNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double AmountOfMonthly { get; set; }

        public LibraryUser() { }

        public LibraryUser(string firstName, string lastName, DateTime dateOfBirth, string cardNumber, DateTime dateofissue, double amountofmonthly)
            : base(firstName, lastName, dateOfBirth)
        {
            CardNumber = cardNumber;
            DateOfIssue = dateofissue;
            AmountOfMonthly = amountofmonthly;
        }
        public LibraryUser(LibraryUser libraryuser) : base(libraryuser)
        {
            CardNumber = libraryuser.CardNumber;
            DateOfIssue = libraryuser.DateOfIssue;
            AmountOfMonthly = libraryuser.AmountOfMonthly;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер читацького квитка: {CardNumber}\nДата видачі: {DateOfIssue}\nРозмір щомісячного читацького внеску: {AmountOfMonthly}");

        }
    }
}
