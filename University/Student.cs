namespace University;

public class Student : Person {
    private int _courseLevel;
    private string _groupNumber = "Undefined";
    private string _department = "Undefined";
    private string _university = "Undefined";

    public int CourseLevel { get => _courseLevel; set => _courseLevel = value; }
    public String GroupNumber { get => _groupNumber; set => _groupNumber = value ?? "Undefined"; }
    public String Department { get => _department; set => _department = value ?? "Undefined"; }
    public String University { get => _university; set => _university = value ?? "Undefined"; }

    public Student(string firstName, string lastName, DateOnly dateOfBirth, int courseLevel, 
            string department, string university) : base(firstName, lastName, dateOfBirth) {
        this.CourseLevel = courseLevel;
        this.Department = department;
        this.University = university;
    }

    public Student(string firstName, string lastName, DateOnly dateOfBirth, int courseLevel, 
            string department, string university, string groupNumber) : base(firstName, lastName, dateOfBirth) {
        this.CourseLevel = courseLevel;
        this.Department = department;
        this.University = university;
        this.GroupNumber = groupNumber;
    }

    public override void ShowInfo() {
        Console.WriteLine("Student:");
        Console.WriteLine($"  First name: {this.FirstName}");
        Console.WriteLine($"  Last name: {this.LastName}");
        Console.WriteLine($"  Date of birth: {this.DateOfBirth}");
        Console.WriteLine($"  Course level: {this.CourseLevel}");
        Console.WriteLine($"  Group number: {this.GroupNumber}");
        Console.WriteLine($"  Department: {this.Department}");
        Console.WriteLine($"  University: {this.University}");
    }
}
