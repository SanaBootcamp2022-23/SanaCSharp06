namespace ClassLibrary
{
    public class People
    {
        public string FirstName { set; get; } 
        public string LastName { set; get; }
        public string? Date { set; get; }

        public People(string name,string lastname, string date) {
            FirstName = name;
            LastName = lastname;
            Date = date;
        }
        public People(string name, string lastname)
        {
            FirstName = name;
            LastName = lastname;
            Date = null;
        }

        public People() { }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"People Info:\n" +
                $"Name: {this.FirstName}\n" +
                $"SurName: {this.LastName}\n" +
                $"Date: {this.Date}");
        }

    }
}