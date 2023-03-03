namespace ClassLibrary
{
    public class Teacher : Person
    {
        public string Position { get; }
        public string Department { get; }
        public string University { get; }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, string position, string department,
            string university)
            : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Department = department;
            University = university;
        }

        public Teacher(Person person, string position, string department, string university)
            : base(person.FirstName, person.LastName, person.DateOfBirth)
        {
            Position = position;
            Department = department;
            University = university;
        }

        public Teacher()
        {
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Посада: {0}", Position);
            Console.WriteLine("Департамент: {0}", Department);
            Console.WriteLine("Вищий навчальний заклад: {0}", University);
        }
    }
}