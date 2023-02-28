namespace ClassLibrary
{
    public class Student : Entrant
    {
        public int Course { get; set; }
        public string GroupName { get; set; }
        public string Faculty { get; set; }
        public string UniversityName { get; set; }

        public Student() { }

        public Student(string firstName, string lastName, DateTime dateOfBirth, double numberOfPointsOfEIT, double numberOfPointsOfEducational, string schoolName, int course, string groupname, string faculty, string universityName)
            : base(firstName, lastName, dateOfBirth, numberOfPointsOfEIT, numberOfPointsOfEducational, schoolName)
        {
            Course = course;
            GroupName = groupname;
            Faculty = faculty;
            UniversityName = universityName;
        }
        public Student(Student student) : base(student)
        {
            Course = student.Course;
            GroupName = student.GroupName;
            Faculty = student.Faculty;
            UniversityName = student.UniversityName;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Курс: {Course}\nГрупа: {GroupName}\nФакультет: {Faculty}\nУніверситет: {UniversityName}");

        }
    }
}
