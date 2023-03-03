using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser:Person
    {
        public int NumberOfTicket{ get; set; }
        public string DateOfIssue { get; set; } = null!;
        public double EveryMonthPay { get; set; }
        public LibraryUser(Person person,LibraryUser user)
            :base(person)
        {
            NumberOfTicket= user.NumberOfTicket;
            DateOfIssue= user.DateOfIssue;  
            EveryMonthPay= user.EveryMonthPay;
        }
        public LibraryUser(Person person, int ticket,string date,double pay)
           : base(person)
        {
            NumberOfTicket = ticket;
            DateOfIssue = date;
            EveryMonthPay = pay;
        }
        public override sealed void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер білету {NumberOfTicket},дата видачі {DateOfIssue},щомісячна плата {EveryMonthPay}");
        }
    }
}
