class Teacher : Human
{
    public string Position { get; set; }
    public string Department { get; set; }
    public string University { get; set; }

    public Teacher(string firstName, string lastName, DateTime birthDate,
                   string position, string department, string university)
        : base(firstName, lastName, birthDate)
    {
        Position = position;
        Department = department;
        University = university;
    }

    public Teacher(string firstName, string lastName, DateTime birthDate,
                 string position, string department)
      : base(firstName, lastName, birthDate)
    {
        Position = position;
        Department = department;
        University = "KPI";
    }

    public Teacher()
    {
    }
    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"University: {University}");
    }
}