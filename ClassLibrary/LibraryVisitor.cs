using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryVisitor : Person
    {
        public int NumberOfTicket { get; set; } = 0;
        public string Date { get; set; } = "26.06.2021";
        public int AmountOfFee { get; set; } = 124;
        public LibraryVisitor()
        {

        }
        public LibraryVisitor(string dateOfBirthday, string name, string surname, int numberOfTicket, string date, int amountOfFee)
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
                $"Date of bitrthday: {DateOfBirthday} NumberOfTicket: {NumberOfTicket} Date: {Date} " +
                $"AmountOfFee: {AmountOfFee}");
        }
    }
}
