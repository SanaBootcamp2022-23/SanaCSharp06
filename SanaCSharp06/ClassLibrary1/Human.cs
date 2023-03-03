namespace ClassLibrary1
{
    public class Human
    {
        public string Name { get; set; }
        public string SecondName { get; set; }

        public Human(string name, string secondName)
        {
            Name = name;
            SecondName = secondName;
        }

        public Human(string name)
        {
            Name = name;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Last Name: {SecondName}");
        }
    }
}