namespace ClassLibrary1
{
    public class Person
    {
        public string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string DateOfBirth { get; set; }

        public Person(string firstName, string lastName, string dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string ShowInfo()
        {
            return $"{FirstName} {LastName} {DateOfBirth}";
        }
    }
}