namespace University
{
    public class Applicant : Person
    {
        public double ZNORate
        {
            get { return ZNORate; }
            set
            {
                if (value >= 100 && value <= 200)
                    ZNORate = value;
            }
        }
        public double SchoolCertificateRate
        {
            get { return SchoolCertificateRate; }
            set
            {
                if (value > 0 && value < 12)
                    SchoolCertificateRate = value;
            }
        }
        public string SchoolName
        {
            get { return SchoolName; }
            set
            {
                if (!String.IsNullOrEmpty(SchoolName))
                    SchoolName = value;
            }
        }

        public Applicant() { }
        public Applicant(string name, string surname, DateTime dateOfBirth, double zNORate, double schoolCertificateRate, string schoolName) : base(name, surname, dateOfBirth)
        {
            ZNORate = zNORate;
            SchoolCertificateRate = schoolCertificateRate;
            SchoolName = schoolName;
        }
        public Applicant(string Name, string Surname, DateTime DateOfBirth, double zNORate, double schoolCertificateRate) : this(Name, Surname, DateOfBirth, zNORate, schoolCertificateRate, "")
        { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Rate of ZNO certificates: {ZNORate}\nRate of school certificates: {SchoolCertificateRate}\n" +
                $"Name of school: {SchoolName}");
        }
    }
}
