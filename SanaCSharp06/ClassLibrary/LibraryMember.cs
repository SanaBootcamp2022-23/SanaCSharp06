using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryMember:People
    {
        protected int _Id;
        protected DateTime _StartDate;
        protected Decimal _Payment;

        public LibraryMember(string firstName, string lastName, DateTime dbirth, int Id, DateTime StartDate, Decimal Payment):base(firstName, lastName, dbirth)
        { 
            _Id = Id;
            _StartDate = StartDate;
            _Payment = Payment;
        }

        public LibraryMember(string firstName, string lastName, int day, int month, int year, int Id, DateTime StartDate, Decimal Payment) : base(firstName, lastName, day, month, year)
        {
            _Id = Id;
            _StartDate = StartDate;
            _Payment = Payment;
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public DateTime StartDate
        { 
            get { return _StartDate; } 
            set { _StartDate = value;} 
        }

        public Decimal Payment
        { 
            get { return _Payment; }
            set { _Payment = value;}
        }

        public override string ShowInfo()
        {
            return base.ShowInfo() + $"{Id} {StartDate} {Payment}";
        }
    }
}
