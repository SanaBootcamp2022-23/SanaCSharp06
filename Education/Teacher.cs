namespace Education;

using System.Text;

public class Teacher : Human
{
  public string University { get; set; }
  public string Department { get; set; }
  public string Position { get; set; }

  public Teacher(
    string firstName,
    string lastName,
    DateTime birthDay,
    string university,
    string department,
    string position
  ) : base(firstName, lastName, birthDay)
  {
    University = university;
    Department = department;
    Position = position;
  }

  public Teacher(
    Human human,
    string universityName,
    string department,
    string position
  ) : this
  (
    human.FirstName,
    human.LastName,
    human.Birthday,
    universityName,
    department,
    position
  )
  { }

  public override string ToString()
  {
    StringBuilder info = new();

    info.Append(base.ToString());
    info.Append($"\n\t University: ");
    info.Append($"\n\t\t University name: {University}");
    info.Append($"\n\t\t Department: {Department}");
    info.Append($"\n\t\t Position: {Position}");

    return info.ToString();
  }

  public override void ShowInfo()
  {
    Console.WriteLine(this);
  }
}

