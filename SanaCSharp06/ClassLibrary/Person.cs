using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Date { get; set; }

        public Person(string firstName, string lastName, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Date = date;
        }
        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public void SetFirstName(string firstName)
        {
            FirstName=firstName;
        }

        public string GetLastName()
        {
            return LastName;
        }
        public void SetLastName(string lastName)
        {
            LastName= lastName;
        }

        public DateTime GetDate()
        {
            return Date;
        }
        public void SetDate(DateTime date)
        {
            Date = date;
        }

        public virtual string ShowInfo()
        {
            return $"Class Person => {FirstName} {LastName} {Date.Year}-{Date.Month}-{Date.Day}";
        }
    }
}
