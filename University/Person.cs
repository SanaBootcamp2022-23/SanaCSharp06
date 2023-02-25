namespace University
{
    public class Person
    {
        public string Name
        {
            get { return Name; }
            set
            {
                if (!String.IsNullOrEmpty(Name))
                    Name = value;
            }
        }
        public string Surname
        {
            get { return Surname; }
            set
            {
                if (!String.IsNullOrEmpty(Surname))
                    Surname = value;
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
                              $"Date of birth: {DateOfBirth.ToShortDateString()}\n");
        }
    }
}