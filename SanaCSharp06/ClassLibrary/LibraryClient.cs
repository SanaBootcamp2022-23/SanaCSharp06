using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryClient : Human
    {
        protected int numberOfReadingTicket;
        protected DateOnly dateOfGiving;
        protected double monthFee;
        public LibraryClient()
        {
            numberOfReadingTicket = 0;
            dateOfGiving = DateOnly.MinValue;
            monthFee= 0;
        }
        public LibraryClient(string name, string surname, DateOnly birthdayDate, int numberOfReadingTicket,
            DateOnly dateOfGiving, double monthFee) : base(name, surname, birthdayDate) 
        {
            this.numberOfReadingTicket = numberOfReadingTicket;
            this.dateOfGiving = dateOfGiving;
            this.monthFee = monthFee;
        }
        public LibraryClient(int numberOfReadingTicket, DateOnly dateOfGiving, double monthFee)
        {
            this.numberOfReadingTicket = numberOfReadingTicket;
            this.dateOfGiving = dateOfGiving;
            this.monthFee = monthFee;
        }
        public int NumberOfReading { get; set; }
        public DateOnly DateOfGiving { get;set; }
        public double MonthFee { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine("Library client: ");
            Console.WriteLine($"  First name: {this.name}");
            Console.WriteLine($"  Last name: {this.surname}");
            Console.WriteLine($"  Date of birth: {this.birthdayDate}");
            Console.WriteLine($"  Number of reading ticket: {this.numberOfReadingTicket}");
            Console.WriteLine($"  Date of giving: {this.dateOfGiving}");
            Console.WriteLine($"  Month fee: {this.monthFee}");
        }
    }
}
