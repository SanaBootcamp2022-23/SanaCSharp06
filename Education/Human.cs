namespace Education;

using System.Text;

public class Human
{
  public string FirstName { get; set; } = string.Empty;
  public string LastName { get; set; } = string.Empty;
  public DateTime Birthday { get; set; }

  public Human() { }

  public Human(string firstName, string lastName) : this
  (
    firstName, lastName, DateTime.Today
  )
  { }

  public Human(string firstName, string lastName, DateTime birthDay)
  {
    FirstName = firstName;
    LastName = lastName;
    Birthday = birthDay;
  }

  public override string ToString()
  {
    StringBuilder info = new();

    info.Append($"{LastName} {FirstName} ({this.GetType().Name})");
    info.Append($"\n\t Birthday: {Birthday:d}");

    return info.ToString();
  }

  public virtual void ShowInfo()
  {
    Console.WriteLine(this);
  }
}
