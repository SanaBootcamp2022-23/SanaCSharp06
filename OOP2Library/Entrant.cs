namespace OOP2Library
{
    public class Entrant : Person
    {
        public string InstitutionName { get; }
        public int EducationScore { get; }
        private List<(string subject, int score)> _EIATests;

        public Entrant(string firstName, string lastName, DateTime birthday,
            string institutionName, int educationScore,
            List<(string subject, int score)> EIATests)
            : base(firstName, lastName, birthday)
        {
            InstitutionName = institutionName;
            EducationScore = educationScore;
            _EIATests = new List<(string subject, int score)>(EIATests);

            _title = "Абітурієнт";
        }
        public Entrant(string firstName, string lastName, DateTime birthday,
            string institutionName, int educationScore)
            : this(firstName, lastName, birthday, institutionName,
                educationScore, new List<(string subject, int score)>()) { }
        public Entrant(Person person, string institutionName, int educationScore,
            List<(string subject, int score)> EIATests)
            : this(person.FirstName, person.LastName, person.Birthday,
                  institutionName, educationScore, EIATests) { }
        public Entrant(Person person, string institutionName, int educationScore)
            : this(person.FirstName, person.LastName, person.Birthday,
                  institutionName, educationScore) { }

        /// <summary>
        /// Returns a generic list that contains pairs of string subjects and int scores.
        /// </summary>
        public List<(string subject, int score)> GetEIA()
        {
            return new List<(string subject, int score)>(_EIATests);
        }

        /// <summary>
        /// Add a new record to the entrant's EIA list.
        /// </summary>
        /// <exception cref="Exceptions.EIATestDuplicateException"></exception>
        public void AddEIA(string subject, int score)
        {
            if (_EIATests.Any(t => t.subject.Equals(subject, StringComparison.OrdinalIgnoreCase)))
                throw new Exceptions.EIATestDuplicateException();
            _EIATests.Add((subject, score));
        }
        /// <summary>
        /// Remove a test by the subject name.
        /// </summary>
        /// <exception cref="ArgumentNullException"></exception>
        public void RemoveEIA(string subject)
        {
            try
            {
                var test = _EIATests.First(t => t.subject.Equals(subject, StringComparison.OrdinalIgnoreCase));
                _EIATests.Remove(test);
            }
            catch (InvalidOperationException)
            {
                throw new Exceptions.EIATestNotFoundExceptio();
            }
        }
        /// <summary>
        /// Returns the average EIA score for this entrant.
        /// </summary>
        public float EIAScore()
        {
            return (float)_EIATests.Sum(t => t.score) / _EIATests.Count;
        }

        public override string ShowInfo()
        {
            string result = base.ShowInfo() + 
                $"\n\tНазва навчального закладу: {InstitutionName}" +
                $"\n\tДокумент про освіту: {EducationScore} б" +
                $"\n\tРезультати ЗНО:";
            foreach (var (subject, score) in _EIATests)
                result += $"\n\t\t{subject}: {score}";
            return result + $"\n\tСередній результат ЗНО: {EIAScore():F2}";
        }
    }
}
