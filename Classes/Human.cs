namespace Classes
{
    public class Human
    {
        protected string Name;
        protected string Surname;
        protected string Birthday;

        public Human()
        {
            Name = "Name";
            Surname = "Surname";
            Birthday = "Birthday";
        }

        public Human(string name, string surname, string birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public Human(Human obj)
        {
            Name = obj.Name;
            Surname = obj.Surname;
            Birthday = obj.Birthday;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetSurname()
        {
            return Surname;
        }

        public string GetBirthday()
        {
            return Birthday;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetSurname(string surname)
        {
            Surname = surname;
        }

        public void SetBirthday(string birthday)
        {
            Birthday = birthday;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"\nІм'я та прізвище: {Name} {Surname}");
            Console.WriteLine($"Дата народження: {Birthday}");
        }
    }
}