using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : People
    {
        public string Id { set; get; }
        public string DateOut { set; get; }
        public double Contribution { set; get; }

        public LibraryUser() { }
        public LibraryUser(string name, string lastname, string date, string id, string dateout, double contribution) : base(name, lastname, date)
        {
            this.Id = id;
            this.DateOut = dateout;
            this.Contribution = contribution;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"LibraryUser Info:\n" +
                $"Name: {this.FirstName}\n" +
                $"SurName: {this.LastName}\n" +
                $"Date: {this.Date}\n" +
                $"Id: {this.Id}\n" +
                $"DateOut: {this.DateOut}\n" +
                $"Contribution: {this.Contribution}\n");

        }
     


    }
}
