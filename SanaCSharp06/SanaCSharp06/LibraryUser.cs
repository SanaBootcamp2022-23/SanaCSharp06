using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06
{
    internal class LibraryUser : Person
    {
        protected string issueDate;
        public int LibraryId { get; set; }
        public string IssueDate 
        { 
            get { return issueDate; } 
            set { if (issueDate != "") issueDate = value; } 
        }
        public int MonthlyPrice { get; set; }
        public LibraryUser(string firstName, string lastName, string birthDate,
            int libraryId, string issueDate, int monthlyPrice) : 
            base(firstName, lastName, birthDate)
        {
            LibraryId = libraryId;
            IssueDate = issueDate;
            MonthlyPrice = monthlyPrice;
        }
        public LibraryUser(string firstName, string lastName, string birthDate,
            int libraryId) : base(firstName, lastName, birthDate)
        {
            LibraryId = libraryId;
        }
        public override string GetFullInfo()
        {
            return $"\n{FirstName} {LastName} ({BirthDate})" +
                $"\nWith {LibraryId} ID ({IssueDate}).PRICE {MonthlyPrice} $";
        }
    }
}
