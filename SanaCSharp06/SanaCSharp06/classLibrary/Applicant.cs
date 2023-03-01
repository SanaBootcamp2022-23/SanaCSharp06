class Applicant : Human
{
    public int ZnoScore { get; set; }
    public int EducationScore { get; set; }
    public string HighSchool { get; set; }

    public Applicant(string firstName, string lastName, DateTime dateOfBirth, int znoScore, int educationScore, string highSchool)
        : base(firstName, lastName, dateOfBirth)
    {
        ZnoScore = znoScore;
        EducationScore = educationScore;
        HighSchool = highSchool;
    }

    public Applicant(string firstName, string lastName, DateTime dateOfBirth, int educationScore, string highSchool)
    : base(firstName, lastName, dateOfBirth)
    {
        ZnoScore = 100;
        EducationScore = educationScore;
        HighSchool = highSchool;
    }
    public Applicant()
    {
    }
    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("----- Applicant Info -----");
        Console.WriteLine("ZNO score: {0}", ZnoScore);
        Console.WriteLine("Education score: {0}", EducationScore);
        Console.WriteLine("High school: {0}", HighSchool);
    }
}
