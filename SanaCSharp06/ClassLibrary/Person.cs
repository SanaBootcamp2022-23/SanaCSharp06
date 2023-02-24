namespace ClassLibrary
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
        }
        public Person() { }

        public virtual void ShowInfo()
        {
            if (BirthDate.Year == 1)
            {
                string information = $"Ім'я: {FirstName};" +
                    $"\nПрізвище: {LastName};";
                Console.WriteLine(information);
            }
            else
            {
                string information = $"Ім'я: {FirstName};" +
                    $"\nПрізвище: {LastName};" +
                    $"\nДата народження: {BirthDate.Day}.{BirthDate.Month}.{BirthDate.Year};";
                Console.WriteLine(information);
            }
        }
    }
}