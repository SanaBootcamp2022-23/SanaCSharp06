using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLibrary
{
    public class Entrant : Person
    {
        public float ZNOPoints { get; set; }
        public float SchoolPoints { get; set; }
        public string SchoolName { get; set; }
        public Entrant(string firstName, string lastName, DateTime birthDate, float ZNOPoints, float schoolPoints, string schoolName
            ) : base(firstName, lastName, birthDate)
        {
            this.ZNOPoints = ZNOPoints;
            SchoolPoints = schoolPoints;
            SchoolName = schoolName;

        }
        public Entrant(Person person, float ZNOPoints, float schoolPoints, string schoolName
            ) : base(person.FirstName, person.LastName, person.BirthDate)
        {
            this.ZNOPoints = ZNOPoints;
            SchoolPoints = schoolPoints;
            SchoolName = schoolName;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, BirthDate: {BirthDate.ToString("dd'-'MM'-'yyyy")}," +
                $" ZNO points: {ZNOPoints}, School points: {SchoolPoints}, School name: {SchoolName}");
        }
    }
}
