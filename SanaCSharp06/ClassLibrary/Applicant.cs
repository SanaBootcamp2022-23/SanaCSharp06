namespace ClassLibrary
{
    public class Applicant : Person
    {
        public Dictionary<string, double> PointsOfZnoCertificate { get; set; } = null!;
        public double AvaragePointOfSchoolGraduateCertificate { get; set; }
        public string nameOfSchool { get; set; }
        public Applicant(Person person, Dictionary<string, double> zno, double schoolAvar, string nameOfSchool)
            : base(person)
        {
            this.nameOfSchool = nameOfSchool;
            PointsOfZnoCertificate = zno;
            AvaragePointOfSchoolGraduateCertificate = schoolAvar;
        }
        public Applicant(Person person, Applicant applicant)
            : base(person)
        {
            this.nameOfSchool = applicant.nameOfSchool;
            this.PointsOfZnoCertificate = applicant.PointsOfZnoCertificate;
            this.AvaragePointOfSchoolGraduateCertificate = applicant.AvaragePointOfSchoolGraduateCertificate;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Я склав зно на ");
            foreach (var zno in PointsOfZnoCertificate)
            {
                Console.WriteLine($"{zno.Key} - {zno.Value}");
            }
            Console.WriteLine($"Мій середній бал сертифікату = {AvaragePointOfSchoolGraduateCertificate}");
            Console.WriteLine($"Я закінчив школу {nameOfSchool}");
        }
    }
}
