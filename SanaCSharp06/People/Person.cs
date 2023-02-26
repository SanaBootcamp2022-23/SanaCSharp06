namespace People
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime Birthday { get; set; }
        public Person()
        {
            Name = string.Empty;
            SurName = string.Empty;
            Birthday = DateTime.MinValue;
        }
        public Person(string Name, string SurName)
        {
            this.Name = Name;
            this.SurName = SurName;
            Birthday = DateTime.MinValue;
        }
        public Person(string Name, string SurName, DateTime Birthday)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Birthday = Birthday;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nSurname: {SurName}\nDate of birth: {Birthday.ToShortDateString()}\n");
        }
    }
}