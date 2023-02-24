namespace SanaCSharp06.ClassLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; } = default;
        public Person(string name, string surname, DateTime dateOfBirth) : this(name, surname)
        {
            DateOfBirth = dateOfBirth;
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Person() { }

        public virtual void ShowInfo()
        {
            string info = $"Ім'я: {Name};\nПрізвище: {Surname};";
            info += DateOfBirth == default ? "" : $"\nДата народження: {DateOfBirth.Day}.{DateOfBirth.Month}.{DateOfBirth.Year}";
            Console.WriteLine(info);
        }
    }
}