using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        public int MonthContribution { get; set; }
        public int TicketNum { get; set; }
        public DateTime ReceiveDate { get; set; }
        public LibraryUser(string firstname, string lastname, DateTime birhdate, int MonthContribution, int TicketNum, 
                           DateTime RecieveDate) : base(firstname, lastname, birhdate)
        {          
            this.MonthContribution = MonthContribution;
            this.TicketNum = TicketNum;
            this.ReceiveDate = RecieveDate;
        }
        public LibraryUser(Person person, int MonthContribution, int TicketNum,
                           DateTime ReceiveDate) : this(person.firstname, person.lastname, person.dateofbirth, MonthContribution, TicketNum, ReceiveDate)
        { }
        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nНомер читацького квитка: {TicketNum} " +
            $"\nРозмір щомісячного читацького внеску: {MonthContribution} \nДата видачі: {ReceiveDate.Day}.{ReceiveDate.Month}.{ReceiveDate.Year}";
        }
    }
}