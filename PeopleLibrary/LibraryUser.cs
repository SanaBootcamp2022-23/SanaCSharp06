using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLibrary
{
    public class LibraryUser : Person
    {
        public string CardNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public float MonthlyContibution { get; set; }
        public LibraryUser(string firstName, string lastName, DateTime birthDate, string cardNumber, DateTime dateOfIssue,
            float monthlyContibution)
            : base(firstName, lastName, birthDate)
        {
            CardNumber = cardNumber;
            DateOfIssue = dateOfIssue;
            MonthlyContibution = monthlyContibution;
        }
        public LibraryUser(Person person, string cardNumber, DateTime dateOfIssue, float monthlyContibution)
            : base(person.FirstName, person.LastName, person.BirthDate)
        {
            CardNumber = cardNumber;
            DateOfIssue = dateOfIssue;
            MonthlyContibution = monthlyContibution;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, BirthDate: {BirthDate.ToString("dd'-'MM'-'yyyy")}, " +
                $"Card: {CardNumber}, Date of Issue: {DateOfIssue.ToString("dd'-'MM'-'yyyy")}, Monthly Contibution: {MonthlyContibution} ");
        }
    }
}
