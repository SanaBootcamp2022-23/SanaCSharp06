using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        public string ReaderTicketNumber { get; set; }     // Номер читацького квитка
        public string DateOfIssue { get; set; }         // Дата видачі
        public double AmountFee { get; set; }           // Розмір щомісячного читацького внеску
        public LibraryUser(string name, string surname, string birthday, string readerTicketNumber, string dateOfIssue, double amountFee) 
            : base(name, surname, birthday)
        { 
            ReaderTicketNumber= readerTicketNumber;
            DateOfIssue= dateOfIssue;
            AmountFee= amountFee;
        }
        public LibraryUser(string name, string surname, string birthday, string dateOfIssue, double amountFee)
            : base(name, surname, birthday)
        {
            DateOfIssue = dateOfIssue;
            AmountFee = amountFee;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер читацького квитка:     {ReaderTicketNumber}");
            Console.WriteLine($"Дата видачі:                 {DateOfIssue}");
            Console.WriteLine($"Щомісячний читацький внесок: {AmountFee}");
        }
    }
}
