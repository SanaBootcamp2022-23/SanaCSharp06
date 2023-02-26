namespace SanaCSharp06.Classes
{
    public class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime BirthDate { set; get; }

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
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {FirstName},\nLast name: {LastName},\nBirthday: {BirthDate}");
            Console.WriteLine();
        }
    }
}
