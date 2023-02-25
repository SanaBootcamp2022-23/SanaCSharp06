namespace PeopleLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = DateTime.Now;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, BirthDate: {BirthDate.ToString("dd'-'MM'-'yyyy")} ");
        }

    }
}