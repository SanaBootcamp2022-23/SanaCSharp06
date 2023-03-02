using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class LibraryUser : Person
    {
        public int LibTicketId { get; set; }
        public string DateOfIssue { get; set; }
        public int Vnesok { get; set; }
        public LibraryUser(string name, string surname, int libTicketId, string dateOfIssue, int vnesok) : base(name, surname)
        {
            LibTicketId = libTicketId;
            DateOfIssue = dateOfIssue;
            Vnesok = vnesok;
        }
        public LibraryUser(string name, string surname, int vnesok) : base(name, surname)
        {
            Vnesok = vnesok;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер читацького квитка: {LibTicketId}\nДата видачі квитка: {DateOfIssue}\nЩомісячний читацький внесок: {Vnesok}\n");
        }
        public LibraryUser()
        {

        }
    }
}
