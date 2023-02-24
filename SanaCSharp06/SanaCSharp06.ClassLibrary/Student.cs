namespace SanaCSharp06.ClassLibrary
{
    public class Student : Person
    {
        public short YearOfStudying { get; set; }
        public string GroupName { get; set; }
        public string FacultyName { get; set; }
        public string UniversityName { get; set; } = String.Empty;

        public Student(short yearOfStudying, string groupName, string facultyName, string universityName) : this(yearOfStudying, groupName, facultyName)
        {
            YearOfStudying = yearOfStudying;
            GroupName = groupName;
            FacultyName = facultyName;
            UniversityName = universityName;
        }
        public Student(short yearOfStudying, string groupName, string facultyName)
        {
            YearOfStudying = yearOfStudying;
            GroupName = groupName;
            FacultyName = facultyName;
        }
        public Student() { }
        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Курс навчання: {YearOfStudying};\nНазва групи: {GroupName};\nНазва факультету: {FacultyName};";
            info += UniversityName == String.Empty ? "" : $"\nНазва вищого навчального закладу: {UniversityName}";
            Console.WriteLine(info);
        }
        
    }
}