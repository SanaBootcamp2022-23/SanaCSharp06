namespace ClassLibrary
{
    public class Person
    {
        protected string _name { get; set; }
        protected string _surname { get; set; }
        protected DateTime _dateTime { get; set; }
        public Person() { }
        public Person (string name, string surname, DateTime dateTime)
        {
            _name = name;
            _surname = surname;
            _dateTime = dateTime;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Surname: {_surname}");
            Console.WriteLine($"Date: {_dateTime.Year}.{_dateTime.Month}.{_dateTime.Day}.");
        }
    }
}