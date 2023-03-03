namespace ClassLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public Person(string name, string surname, string birthday)
        {
            Name= name;
            Surname= surname;
            Birthday= birthday;
        }        
        public Person(string name, string surname)
        {
            Name= name;
            Surname= surname;
            Birthday= "01.01.2001";
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я:            {Name}");
            Console.WriteLine($"Прізвище:        {Surname}") ;
            Console.WriteLine($"Дата народження: {Birthday}");
        }
    }
}