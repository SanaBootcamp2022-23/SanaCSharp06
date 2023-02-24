namespace OOP2Library
{
    public class Student : Entrant
    {
        public string UniversityName { get; }
        public string Faculty { get; set; }
        public string Course { get; set; }
        public string Group { get; set; }
        
        public Student(string firstName, string lastName, DateTime birthday,
            string institutionName, int educationScore,
            List<(string subject, int score)> EIATests,
            string univesityName, string faculty, string course, string group)
            : base(firstName, lastName, birthday, institutionName, educationScore, EIATests)
        {
            UniversityName = univesityName;
            Faculty = faculty;
            Course = course;
            Group = group;

            _title = "Студент";
        }
        public Student(Person person, string institutionName, int educationScore,
            List<(string subject, int score)> EIATests,
            string univesityName, string faculty, string course, string group)
            : this(person.FirstName, person.LastName, person.Birthday, institutionName,
                  educationScore, EIATests, univesityName, faculty, course, group) { }
        public Student(Entrant entrant, string univesityName, string faculty, string course,
            string group) : this(entrant.FirstName, entrant.LastName, entrant.Birthday,
                entrant.InstitutionName, entrant.EducationScore, entrant._EIATests,
                univesityName, faculty, course, group) { }

        public override string ShowInfo()
        {
            return base.ShowInfo() + 
                $"\n\tУніверситет: {UniversityName}:" +
                $"\n\t\tФакультет: {Faculty}" +
                $"\n\t\t{Course} курс, група {Group}";
        }
    }
}
