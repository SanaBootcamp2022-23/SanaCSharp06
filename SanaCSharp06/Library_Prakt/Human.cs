namespace Library_Prakt
{
    public class Human
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { if (value != null) name = value; }
        }

        protected string surname;
        public string Surname
        {
            get { return surname; }
            set { if (value != null) surname = value; }
        }

        protected DateTime dateOfBirthday;
        public DateTime DateOfBirthday
        {
            get { return dateOfBirthday; }
            set { dateOfBirthday = value; }
        }

        public Human (string name, string surname, DateTime dateOfBirthday)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirthday = dateOfBirthday;
        }
        public Human () : this("Undefined","Undefined", new DateTime()) { }
        public Human (Human person) : this(person.name,person.surname,person.dateOfBirthday) { }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {this.name}");
            Console.WriteLine($"Surname: {this.surname}");
            Console.WriteLine($"Date of Birthday: {this.dateOfBirthday.Day}.{this.dateOfBirthday.Month}.{this.dateOfBirthday.Year}");
            Console.WriteLine();
        }
    }
}