using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Student
    {

        protected int userID { get; set; }
        protected DateTime givenDate { get; set; }
        protected int payment { get; set; }
        public LibraryUser(string firstName, string lastName,int userID, DateTime givenDate, int payment, int courseNum, string groupNum, string facultyName, string universityName) 
            : base(firstName, lastName, courseNum, groupNum, facultyName, universityName)
        {
            this.userID = userID;
            this.givenDate = givenDate;
            this.payment = payment;
        }
        public LibraryUser(string firstName, string lastName, int payment, int courseNum, string groupNum, string facultyName, string universityName)
            : base(firstName, lastName, courseNum, groupNum, facultyName, universityName)
        {
            this.payment = payment;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($" Name: {this.firstName}");
            Console.WriteLine($" Surname: {this.lastName}");
            Console.WriteLine($" User ID: {this.userID}");
            Console.WriteLine($" Acces given: {this.givenDate}");
            Console.WriteLine($" Month price: {this.payment}");
            Console.WriteLine($" Course number: {this.courseNum}");
            Console.WriteLine($" Group: {this.groupNum}");
            Console.WriteLine($" Faculty: {this.facultyName}");
            Console.WriteLine($" University: {this.universityName}");
            Console.WriteLine("----------------------------------");
        }
    }
}
