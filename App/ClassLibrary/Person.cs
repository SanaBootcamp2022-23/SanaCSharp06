using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Person
    {

        protected string firstName { get; set; }
        protected string lastName { get; set; }
        protected DateTime birthDate { get; set; }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
        public Person(Person obj)
        {
            firstName = obj.firstName;
            lastName = obj.lastName;
            birthDate = obj.birthDate;
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($" Name: {this.firstName}");
            Console.WriteLine($" Surname: {this.lastName}");
            Console.WriteLine($" Birth date: {this.birthDate}");
            Console.WriteLine("----------------------------------");
        }
    }
}