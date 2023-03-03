using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySana06
{
    public class LibraryVisitor:Person
    {
        protected int visitorId;
        protected int dayOfIssue;
        protected int mounthOfIssue;
        protected int yearOfIssue;
        protected int contributionAmount;

        public int VisitorId { get { return visitorId; } set { visitorId = value; } }
        public int DayOfIssue { get { return dayOfIssue; } set { dayOfIssue = value; } }
        public int MounthOfIssue { get { return mounthOfIssue; } set { mounthOfIssue = value; } }
        public int YearOfIssue { get { return yearOfIssue; } set { yearOfIssue=value; } }
        public int ContributionAmount { get { return contributionAmount; } set { contributionAmount = value; } }

        public LibraryVisitor() { }
        public LibraryVisitor(int visitorId, int dayOfIssue, int mounthOfIssue, int yearOfIssue, int contributionAmount)
        {
            VisitorId = visitorId;
            DayOfIssue = dayOfIssue;
            MounthOfIssue = mounthOfIssue;
            YearOfIssue = yearOfIssue;
            ContributionAmount = contributionAmount;
        }
        public LibraryVisitor(Person person, int visitorId, int dayOfIssue, int mounthOfIssue, int yearOfIssue, int contributionAmount)
            : base(person.Firstname, person.Lastname, person.DayOfBirth, person.MontthOfBirth, person.YearOfBirth)
        {
            VisitorId = visitorId;
            DayOfIssue = dayOfIssue;
            MounthOfIssue = mounthOfIssue;
            YearOfIssue = yearOfIssue;
            ContributionAmount = contributionAmount;
        }

        public override void ShowInfo()
        {
            base.ShowInfo(); Console.WriteLine($"Номер квитка - {visitorId}, dата видачі квитка - {dayOfIssue:D2}.{mounthOfIssue:D2}.{yearOfIssue}, щомісячний внесок - {contributionAmount}");
        }
    }
}
