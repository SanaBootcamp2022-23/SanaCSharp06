namespace ClassLibrary
{
    public class Person
    {
        protected string Name;
        protected string Surname;
        protected DateTime DateOfBirth;

        public Person(string name, string surname, DateTime dateofbirth):this(name,surname)
        {
            this.DateOfBirth = dateofbirth;
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = new DateTime(2001, 12, 17);
        }

        public string NameProperty
        {
            get { return Name; }
            set { Name = value; }
        }

        public string SurnameProperty
        {
            get { return Surname; }
            set { Surname = value; }
        }

        public DateTime DateOfBirthProperty
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я -> {Name} // прізвище -> {Surname} // дата народження -{ DateOfBirth}\n");
        }

    }
}