namespace University;

public class LibraryCustomer : Person {

    public int Id { get; set; }
    public DateOnly ReceivingDate { get; set; }
    public double Contribution { get; set; }

    public LibraryCustomer(string firstName, string lastName, DateOnly dateOfBirth, 
            int id, DateOnly receivingDate) : base(firstName, lastName, dateOfBirth) {
        this.Id = id;
        this.ReceivingDate = receivingDate;
    }

    public LibraryCustomer(string firstName, string lastName, DateOnly dateOfBirth, 
            int id, DateOnly receivingDate, double contribution) : base(firstName, lastName, dateOfBirth) {
        this.Id = id;
        this.ReceivingDate = receivingDate;
        this.Contribution = contribution;
    }

    public override void ShowInfo() {
        Console.WriteLine("Library customer:");
        Console.WriteLine($"  First name: {this.FirstName}");
        Console.WriteLine($"  Last name: {this.LastName}");
        Console.WriteLine($"  Date of birth: {this.DateOfBirth}");
        Console.WriteLine($"  ID: {this.Id}");
        Console.WriteLine($"  Receiving date: {this.ReceivingDate}");
        Console.WriteLine($"  Contribution: {this.Contribution}");
    }
}
