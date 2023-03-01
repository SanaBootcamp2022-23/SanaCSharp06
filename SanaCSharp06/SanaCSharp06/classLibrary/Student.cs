class Student : Human
{
    public int Course { get; set; }
    public string Group { get; set; }
    public string Faculty { get; set; }
    public string University { get; set; }

    public Student(string firstName, string lastName, DateTime dateOfBirth, int course, string group, string faculty, string university)
        : base(firstName, lastName, dateOfBirth)
    {
        Course = course;
        Group = group;
        Faculty = faculty;
        University = university;
    }
    public Student(string firstName, string lastName, DateTime dateOfBirth, string group, string faculty, string university)
        : base(firstName, lastName, dateOfBirth)
    {
        Course = 1;
        Group = group;
        Faculty = faculty;
        University = university;
    }
    public Student()
    {
    }

    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("----- Student Info -----");
        Console.WriteLine("Course: {0}", Course);
        Console.WriteLine("Group: {0}", Group);
        Console.WriteLine("Faculty: {0}", Faculty);
        Console.WriteLine("University: {0}", University);
    }
}