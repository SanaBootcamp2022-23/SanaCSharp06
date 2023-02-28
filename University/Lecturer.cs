namespace University;

public class Lecturer : Person {
    private string _position = "Undefined";
    private string _department = "Undefined";
    private string _university = "Undefined";

    public String Position { get => _position; set => _position = value ?? "Undefined"; }
    public String Department { get => _department; set => _department = value ?? "Undefined"; }
    public String University { get => _university; set => _university = value ?? "Undefined"; }

    public Lecturer(string firstName, string lastName, DateOnly dateOfBirth, 
            string department, string university) : base(firstName, lastName, dateOfBirth) {
        this.Department = department;
        this.University = university;
    }

    public Lecturer(string firstName, string lastName, DateOnly dateOfBirth, 
            string department, string university, string position) : base(firstName, lastName, dateOfBirth) {
        this.Department = department;
        this.University = university;
        this.Position = position;
    }

    public override void ShowInfo() {
        Console.WriteLine("Student:");
        Console.WriteLine($"  First name: {this.FirstName}");
        Console.WriteLine($"  Last name: {this.LastName}");
        Console.WriteLine($"  Date of birth: {this.DateOfBirth}");
        Console.WriteLine($"  Position: {this.Position}");
        Console.WriteLine($"  Department: {this.Department}");
        Console.WriteLine($"  University: {this.University}");
    }
}
