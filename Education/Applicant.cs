namespace Education;

using System.Text;

public class Applicant : Human
{
  public string EducationalInstitutionName { get; set; } = string.Empty;
  public decimal EducationalDocumentScore { get; set; }
  public Dictionary<string, decimal> ZNOScores { get; }

  public Applicant(
    string firstName,
    string lastName,
    DateTime birthDay,
    string educationalInstitutionName,
    decimal educationalDocumentScore
  ) : this
  (
    firstName,
    lastName,
    birthDay,
    educationalInstitutionName,
    educationalDocumentScore,
    new Dictionary<string, decimal>()
  )
  { }

  public Applicant(
    string firstName,
    string lastName,
    DateTime birthDay,
    string educationalInstitutionName,
    decimal educationalDocumentScore,
    Dictionary<string, decimal> znoScores
  ) : base(firstName, lastName, birthDay)
  {
    EducationalInstitutionName = educationalInstitutionName;
    EducationalDocumentScore = educationalDocumentScore;
    ZNOScores = znoScores;
  }

  public void AddZNOScore(string subject, decimal score)
  {
    if (!ZNOScores.ContainsKey(subject))
      ZNOScores.Add(subject, score);
  }

  public void RemoveZNOScore(string subject) => ZNOScores.Remove(subject);

  public decimal ZNOScoreAverage()
  {
    var scores = ZNOScores.Values;
    return scores.Sum() / scores.Count;
  }

  public override string ToString()
  {
    StringBuilder info = new();

    info.Append(base.ToString());
    info.Append($"\n\t Name of educational institution: {EducationalInstitutionName}");
    info.Append($"\n\t Educational document score: {EducationalDocumentScore}");
    info.Append($"\n\t Average ZNO score: {ZNOScoreAverage():F2}");

    info.Append($"\n\t ZNO scores:");
    foreach (var (subject, score) in ZNOScores)
    {
      info.Append($"\n\t\t {subject}: {score}");
    }

    return info.ToString();
  }

  public override void ShowInfo()
  {
    Console.WriteLine(this);
  }
}

