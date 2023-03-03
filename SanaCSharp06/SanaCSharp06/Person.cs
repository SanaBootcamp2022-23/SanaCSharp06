using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06
{
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected string birthDate;
        public string FirstName
        {
            get { return firstName; }
            set { if (firstName != "") firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { if (lastName != "") lastName = value; }
        }
        public string BirthDate
        {
            get { return birthDate; }
            set { if (birthDate != "") birthDate = value; }
        }
        public Person(string firstName, string lastName, string birthDate) 
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual string GetFullInfo()
        {
            return $"{FirstName} {LastName} ({BirthDate})";
        }
    }
}
