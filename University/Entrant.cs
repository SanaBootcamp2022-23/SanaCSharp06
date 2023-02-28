namespace University;

public class Entrant : Person {
    private Dictionary<string, double> _znoResults = new Dictionary<string, double>();
    private double _schoolPoints;
    private string _schoolName = "Undefined";

    public Dictionary<string, double> ZNOResults 
        { get =>  CopyDict(_znoResults); set => _znoResults = CheckZNOResults(value); }
    public double SchoolPoints { get => _schoolPoints; set => _schoolPoints = value; }
    public string SchoolName { get => _schoolName; set => _schoolName = value ?? "Undefined"; }

   
    public Entrant(string firstName, string lastName, DateOnly dateOfBirth, double schoolPoints, string schoolName) 
        : base(firstName, lastName, dateOfBirth) {
        this.SchoolName = schoolName;
        this.SchoolPoints = schoolPoints;
    }

    public Entrant(string firstName, string lastName, DateOnly dateOfBirth, double schoolPoints, string schoolName, 
            Dictionary<string, double> znoResults) : base(firstName, lastName, dateOfBirth) {
        this.SchoolName = schoolName;
        this.SchoolPoints = schoolPoints;
        this.ZNOResults = znoResults;
    }

    private bool CheckZNOPoints(double points) => points == 0.0 || points >= 100 && points <= 200;
    private Dictionary<string, double> CopyDict(Dictionary<string, double> dict) =>
        dict.ToDictionary(
            pair => pair.Key,
            pair => pair.Value
        );

    private Dictionary<string, double> CheckZNOResults(Dictionary<string, double> results) {
        if (results.All(pair => CheckZNOPoints(pair.Value)))
            return CopyDict(results);
        throw new ArgumentException("Not valid ZNO results. Use following rule: 0 not passed, 100-200 points");
    }

    public void AddResult(string subject, double points) {
        if (!CheckZNOPoints(points))
            throw new ArgumentException("Not valid ZNO results. Use following rule: 0 not passed, 100-200 points");
        this._znoResults.Add(subject, points);
    }

    public void DeleteResult(string subject) {
        this._znoResults.Remove(subject);
    }

    public override void ShowInfo() {
        Console.WriteLine("Entrant:");
        Console.WriteLine($"  First name: {this.FirstName}");
        Console.WriteLine($"  Last name: {this.LastName}");
        Console.WriteLine($"  Date of birth: {this.DateOfBirth}");
        Console.WriteLine($"  School name: {this.SchoolName}");
        Console.WriteLine($"  School points: {this.SchoolPoints}");
        Console.WriteLine("  ZNO results:");
        foreach (var pair in this.ZNOResults) {
            Console.WriteLine($"    {pair.Key} - {pair.Value}");
        }
    }
}

