namespace ClassLibrary
{
    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = DateTime.MinValue;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Ім'я: {0}", FirstName);
            Console.WriteLine("Прізвище: {0}", LastName);
            Console.WriteLine("Дата народження: {0:d}", DateOfBirth);
        }
    }
}