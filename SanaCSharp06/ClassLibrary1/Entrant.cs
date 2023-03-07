namespace ClassLibrary1
{
    public class Entrant : Person
    {
        protected int ZnoPoints { get; set; }
        protected int SchoolPoints { get; set; }
        protected string SchoolName { get; set; }

        public Entrant(string firstName, string lastName, string dateOfBirth , int znoPoints, int schoolPoints, string schoolName) : base(firstName, lastName, dateOfBirth)
        {
            ZnoPoints = znoPoints;
            SchoolPoints = schoolPoints;
            SchoolName = schoolName;
        }

        public Entrant(string firstName, string lastName, string schoolName) : base(firstName, lastName)
        {
            SchoolName = schoolName;
        }

        public override string ShowInfo()
        {
            return $"{FirstName} {LastName} {DateOfBirth} {ZnoPoints} {SchoolPoints} {SchoolName}";
        }
    }
}