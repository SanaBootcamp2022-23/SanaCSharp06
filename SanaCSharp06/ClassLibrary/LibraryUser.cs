using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Human
    {
        public int IdUser { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int Fee { get; set; }

        public LibraryUser(string name, string lastName, DateTime dateOfBirth, int idUser, DateTime dateOfIssue, int fee) : base(name, lastName, dateOfBirth)
        {
            IdUser = idUser;
            DateOfIssue = dateOfIssue;
            Fee = fee;
        }
        public LibraryUser(string name, string lastName, DateTime dateOfBirth) : base(name, lastName, dateOfBirth)
        {
            IdUser = new Random().Next(1,10000);
            DateOfIssue = DateTime.Now;
            Fee = 100;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Id user: {IdUser}\nDate of Issue: {DateOfIssue}\nFee: {Fee}$");
        }
    }
}
