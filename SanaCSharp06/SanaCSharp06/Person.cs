using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06
{
    public class Person
    {
        protected string FirstName;
        protected string LastName;
        protected string BirthDate;
        public Person(string firstName, string lastName, string birthDate) 
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
    }
}
