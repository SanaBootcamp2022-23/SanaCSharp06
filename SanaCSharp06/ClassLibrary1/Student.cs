namespace ClassLibrary1
{
    public class Student : Person
    {
        protected int UniversityYear { get; set; }
        protected string Group { get; set; }
        protected string Faculty { get; set; }
        protected string UniversityName { get; set; }

        public Student(string firstName, string lastName, string dateOfBirth, int universityYear, string group,
            string faculty, string universityName)
            : base(firstName, lastName, dateOfBirth)
        {
            UniversityYear = universityYear;
            Group = group;
            Faculty = faculty;
            UniversityName = universityName;
        }

        public Student(string firstName, string lastName, string universityName)
            : base(firstName, lastName)
        {
            UniversityName = universityName;
        }

        public override string ShowInfo()
        {
            return $"{FirstName} {LastName} {DateOfBirth} " +
                   $"{UniversityYear} {Group} {Faculty} {UniversityName}";
        }
    }
}