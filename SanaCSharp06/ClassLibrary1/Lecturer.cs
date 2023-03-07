namespace ClassLibrary1
{
    public class Lecturer : Person
    {
        protected string Position { get; set; }
        protected string Chair { get; set; }
        protected string UniversityName { get; set; }

        public Lecturer(string firstName, string lastName, string dateOfBirth, string position, string chair,
            string universityName)
            : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Chair = chair;
            UniversityName = universityName;
        }

        public Lecturer(string firstName, string lastName, string universityName)
            : base(firstName, lastName)
        {
            UniversityName = universityName;
        }

        public override string ShowInfo()
        {
            return $"{FirstName} {LastName} {DateOfBirth} {Position} {Chair} {UniversityName}";
        }
    }
}