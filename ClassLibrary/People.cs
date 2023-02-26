namespace ClassLibrary
{
    public class People
    {
        protected string Name;
        protected string Surname;
        protected string BirthdayDate;
        public People(string Name, string Surname, string BirthdayDate)
        {

            this.Name = Name;
            this.Surname = Surname;
            this.BirthdayDate = BirthdayDate;
        }
        public People(string Name, string Surname)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.BirthdayDate = "01.01.2000";
        }
        public People(string Name)
        {
            this.Name = Name;
            this.Surname = "Батькович";
            this.BirthdayDate = "01.01.2000";
        }
        public People()
        {
            this.Name = "Іван";
            this.Surname = "Батькович";
            this.BirthdayDate = "01.01.2000";
        }
        public string name
        {
            set { if (value.Length > 0) Name = value; }
            get { return Name; }
        }
        public string surname
        {
            set { if (value.Length > 0) Surname = value; }
            get { return Surname; }
        }
        public string birthdayDate
        {
            set { if (value.Length > 0) BirthdayDate = value; }
            get { return BirthdayDate; }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"І'мя: {Name}");
            Console.WriteLine($"Прізвище: {Surname}");
            Console.WriteLine($"Дата народження: {BirthdayDate}");
        }
    }
}