namespace ClassLibrary
{
    public class Person
    {
        protected string Name;
        protected string Surname;
        protected DateTime DateOfBirthday;

        public Person(string name, string surname, DateTime dateofbirthday)
        {
            this.Name = name;
            this.Surname = surname;
            this.DateOfBirthday = dateofbirthday;
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
            DateOfBirthday = new DateTime(2001, 12, 17);
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

        public DateTime DateOfBirthdayProperty
        {
            get { return DateOfBirthday; }
            set { DateOfBirthday = value; }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я -> {Name} // прізвище -> {Surname} // дата народження -{ DateOfBirthday}\n");
        }

    }
}