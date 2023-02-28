namespace ClassLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            DateOfBirth = person.DateOfBirth;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {FirstName}\nПрізвище: {LastName}\nДата народження: {DateOfBirth.ToShortDateString()}");
        }
    }
}