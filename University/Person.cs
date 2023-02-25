namespace University
{
    public class Person
    {
        private string name;
        private string surname;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    surname = value;
            }
        }
        public DateTime DateOfBirth { get; set; }

        public Person() { }
        public Person(string Name, string Surname, DateTime DateOfBirth)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.DateOfBirth = DateOfBirth;
        }
        public Person(string Name, string Surname) : this(Name, Surname, new DateTime())
        { }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {Surname}\n" +
                              $"Date of birth: {DateOfBirth.ToShortDateString()}");
        }
    }
}