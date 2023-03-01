namespace ClassLibrary
{
    public class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Human(string name, string lastName, DateTime dateOfBirth)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public Human()
        {
            Name = "Human name";
            LastName = "Human lastname";
            DateOfBirth = DateTime.Now;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nLastname: {LastName}\nDate of birthday: {DateOfBirth.ToShortDateString()}");
        }
    }
}