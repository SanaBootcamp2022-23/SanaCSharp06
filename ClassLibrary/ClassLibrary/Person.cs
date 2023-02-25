namespace ClassLibrary
{
    public class Person
    {
        private string firstName = "Петро";
        private string lastName = "Петренко";
        private string dateOfBirth = "01.01.1990";
        public string FirstName { get=>firstName;
            set {
                if (value.Length >= 2)
                    firstName = value;
            } }
        public string LastName { get=>lastName;
            set {
                if (value.Length >= 3)
                    lastName = value;
            } }
        public string DateOfBirth { get=>dateOfBirth;
            set {
                if (value.Length >= 6)
                    dateOfBirth = value;
            } }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }
        public Person(string FirstName, string LastName, string DateOfBirth) : this(FirstName, LastName)
        {
            this.DateOfBirth = DateOfBirth;
        }
        public virtual string ShowInfo() => $"{LastName} {FirstName} \nДата народження: {DateOfBirth}";
    }
}