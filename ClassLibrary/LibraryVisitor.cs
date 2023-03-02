using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryVisitor : Person
    {
        public int NumberOfTicket { get; set; }
        public DateTime Date { get; set; }
        public int AmountOfFee { get; set; }
        public LibraryVisitor()
        {
            NumberOfTicket = 0;
            Date = new DateTime(2021, 9, 1, 0, 0, 0);
            AmountOfFee = 124;
    }
        public LibraryVisitor(DateTime dateOfBirthday, string name, string surname, int numberOfTicket, DateTime date, int amountOfFee)
            : base(dateOfBirthday, name, surname)
        {
            NumberOfTicket = numberOfTicket;
            Date = date;
            AmountOfFee = amountOfFee;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("LibraryVisitor:");
            Console.WriteLine($"Name:{Name} Surname: {Surname} " +
                $"Date of bitrthday: {DateOfBirthday.Day}/{DateOfBirthday.Month}/{DateOfBirthday.Year} NumberOfTicket: {NumberOfTicket} Date: {Date.Day}/{Date.Month}/{Date.Year} " +
                $"AmountOfFee: {AmountOfFee}");
        }
    }
}
