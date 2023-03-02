namespace ClassLibrary1
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Human(string name, string surname, DateTime date)
        {
            Name = name;
            Surname = surname;
            BirthDate = date;
        }
        public Human()
        {
            Name = "";
            Surname = "";
            BirthDate = new DateTime(2000, 1, 1);
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {Name} {Surname}");
            Console.WriteLine($"Дата народження: {BirthDate.ToString("dd.MM.yyyy")}");
        }
    }
}