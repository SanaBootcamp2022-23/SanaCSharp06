using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser:Person
    {
        private int NumberTicket;
        private DateTime DateOfGiving;
        private double PriceForMonth;

        public LibraryUser(string name, string surname, DateTime dateofbirth, int numberTicket, DateTime dateOfGiving, double priceForMonth):this(name, surname, dateofbirth,numberTicket,priceForMonth)
        {
            DateOfGiving = dateOfGiving;
        }
        public LibraryUser(string name, string surname, DateTime dateofbirth, int numberTicket, double priceForMonth):base(name,surname,dateofbirth)
        {
            NumberTicket = numberTicket;
            PriceForMonth = priceForMonth;
            DateOfGiving = DateTime.Now;
        }

        public int NumberTicketProperty
        {
            get { return NumberTicket; }
            set { NumberTicket = value; }
        }

        public DateTime DateOfGivingProperty
        {
            get { return DateOfGiving; }
            set { DateOfGiving = value; }
        }
        public double PriceForMonthProperty
        {
            get { return PriceForMonth; }
            set { PriceForMonth = value; }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Ім'я -> {Name} // прізвище -> {Surname} // дата народження -{DateOfBirth} // номер читацького квитка -> {NumberTicket} // дата видачі ->{DateOfGiving} //  розмір щомісячного читацького внеску ->{PriceForMonth}\n");
        }
    }
}
