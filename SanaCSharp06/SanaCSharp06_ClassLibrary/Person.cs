

namespace SanaCSharp06_ClassLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; } = default;

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

        public Person(string firstName, string lastName, DateTime birthDate) : this(firstName, lastName)
        {
            BirthDate = birthDate;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"First name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"BirthDate: {((BirthDate != default) ? BirthDate.ToShortDateString() : "unknown")}");

        }
    }
}