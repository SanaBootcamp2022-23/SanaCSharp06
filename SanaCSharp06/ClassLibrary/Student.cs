namespace ClassLibrary
{
    public class Student : Person
    {
        public uint YearOfStudy { get; set; }
        public string GroupName { get; set; }
        public string FacultyName { get; set; }
        public string UniversityName { get; set; }
        public Student(string firstName, string lastName, DateTime birthDate, 
            uint yearOfStudy, string groupName, string facultyName, string universityName) : 
            base(firstName, lastName, birthDate)
        {
            YearOfStudy = yearOfStudy;
            GroupName = groupName;
            FacultyName = facultyName;
            UniversityName = universityName;
        }
        public Student(string firstName, string lastName, DateTime birthDate, 
            uint yearOfStudy, string groupName, string facultyName) : 
            base(firstName, lastName, birthDate)
        {
            YearOfStudy = yearOfStudy;
            GroupName = groupName;
            FacultyName = facultyName;
        }
        public Student(string firstName, string lastName, DateTime birthDate,
            string groupName, string facultyName, string universityName) :
            base(firstName, lastName, birthDate)
        {
            GroupName = groupName;
            FacultyName = facultyName;
            UniversityName = universityName;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            string information = $"Курс: {YearOfStudy};" +
                $"\nГрупа: {GroupName};" +
                $"\nФакультет: {FacultyName};" +
                $"\nВищий навчальний заклад: {UniversityName};";
            Console.WriteLine(information);
        }
    }
}
