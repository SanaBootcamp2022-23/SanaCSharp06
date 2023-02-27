using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        protected int _idReaderTicket { get; set; }
        protected DateTime _dateOfIssue { get; set; }
        protected double _contribution { get; set; }
        public LibraryUser() { }
        public LibraryUser(string name, string surname, DateTime dateTime, int idReaderTicket, DateTime dateOfIssue, double contribution) : base(name, surname, dateTime)
        {
            _idReaderTicket = idReaderTicket;
            _dateOfIssue = dateOfIssue;
            _contribution = contribution;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер читацького квитка: {_idReaderTicket}");
            Console.WriteLine($"Дата видачі: {_dateOfIssue.Year}.{_dateOfIssue.Month}.{_dateOfIssue.Day}.");
            Console.WriteLine($"Розмір щомісячного читацького внеску: {_contribution}");
        }
    }
}
