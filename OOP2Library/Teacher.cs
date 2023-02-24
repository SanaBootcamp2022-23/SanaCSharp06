namespace OOP2Library
{
    public class Teacher : Person
    {
        public string UniversityName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public Teacher(string firstName, string lastName, DateTime birthday,
            string universityName, string department, string position)
            : base(firstName, lastName, birthday)
        {
            UniversityName = universityName;
            Department = department;
            Position = position;

            _title = "Викладач";
        }
        public Teacher(Person person, string universityName, string department, string position)
            : this(person.FirstName, person.LastName, person.Birthday,
                  universityName, department, position) { }

        public override string ShowInfo()
        {
            return base.ShowInfo() + "Університет:" +
                $"\n\t\tНазва: {UniversityName}" +
                $"\n\t\tКафедра: {Department}" +
                $"\n\t\tПосада: {Position}";
        }
    }
}
