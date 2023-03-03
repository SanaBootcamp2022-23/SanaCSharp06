namespace Education;

using System.Text;

public class LibraryMember : Human
{
  public int Id { get; set; }
  public DateTime DateOfIssue { get; set; }
  public decimal MonthlyFee { get; set; }

  public LibraryMember(
    string firstName,
    string lastName,
    DateTime birthDay,
    int id,
    decimal monthlyFee
  ) : base(firstName, lastName, birthDay)
  {
    Id = id;
    DateOfIssue = DateTime.Now;
    MonthlyFee = monthlyFee;
  }

  public LibraryMember(Human human, int id, decimal monthlyFee) : this
  (
      human.FirstName, human.LastName, human.Birthday, id, monthlyFee
  )
  { }

  public LibraryMember(
    string firstName,
    string lastName,
    DateTime birthDay,
    int id,
    DateTime dateOfIssue,
    decimal monthlyFee
  ) : base(firstName, lastName, birthDay)
  {
    Id = id;
    DateOfIssue = dateOfIssue;
    MonthlyFee = monthlyFee;
  }

  public override string ToString()
  {
    StringBuilder info = new();

    info.Append(base.ToString());
    info.Append($"\n\t Library card number: {Id}");
    info.Append($"\n\t Card issue date: {DateOfIssue:g}");
    info.Append($"\n\t Monthly fee: {MonthlyFee:F2} UAH");

    return info.ToString();
  }

  public override void ShowInfo()
  {
    Console.WriteLine(this);
  }
}

