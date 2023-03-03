namespace Education;

using System.Text;

public class Student : Human
{
  public int Course { get; set; }
  public string Group { get; set; }
  public string Faculty { get; set; }
  public string University { get; set; }

  public Student(
    string firstName,
    string lastName,
    DateTime birthDay,
    int course,
    string group,
    string faculty,
    string university
  ) : base(firstName, lastName, birthDay)
  {
    Course = course;
    Group = group;
    Faculty = faculty;
    University = university;
  }

  public Student(
    Human human,
    int course,
    string group,
    string faculty,
    string university
  ) : this
  (
    human.FirstName,
    human.LastName,
    human.Birthday,
    course,
    group,
    faculty,
    university
  )
  { }

  public override string ToString()
  {
    StringBuilder info = new();

    info.Append(base.ToString());
    info.Append($"\n\t University: ");
    info.Append($"\n\t\t University name: {University}");
    info.Append($"\n\t\t Faculty: {Faculty}");
    info.Append($"\n\t\t Course: {Course}");
    info.Append($"\n\t\t Group: {Group}");

    return info.ToString();
  }

  public override void ShowInfo()
  {
    Console.WriteLine(this);
  }
}

