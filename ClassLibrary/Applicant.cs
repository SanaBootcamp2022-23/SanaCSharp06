namespace ClassLibrary
{
    public class Applicant : Person
    {
        public int ZnoScore { get; set; }
        public int EducationScore { get; set; }
        public string School { get; set; }

        public Applicant()
        {
        }

        public Applicant(string firstName, string lastName, DateTime dateOfBirth,
            int znoScore, int educationScore, string school)
            : base(firstName, lastName, dateOfBirth)
        {
            ZnoScore = znoScore;
            EducationScore = educationScore;
            School = school;
        }

        public Applicant(Person person, int znoScore,
            int educationScore, string school)
            : base(person.FirstName,person.LastName,person.DateOfBirth)
        {
            ZnoScore = znoScore;
            EducationScore = educationScore;
            School = school;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Кількість балів сертифікатів ЗНО: {0}", ZnoScore);
            Console.WriteLine("Кількість балів за документ про освіту: {0}", EducationScore);
            Console.WriteLine("Назва загальноосвітнього навчального закладу: {0}", School);
        }
    }
}