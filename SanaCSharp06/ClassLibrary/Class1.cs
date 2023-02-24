namespace OOP2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Person(string firstName, string lastName, DateTime birthDate):this(firstName, lastName)
        {
            BirthDate = birthDate;
        }
        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
        public virtual string ShowInfo()
        {
            if (BirthDate.Year == 1)
                return $"Ім'я:{LastName} {FirstName}";
            else return $"Ім'я:{LastName} {FirstName} Дата народження:{BirthDate.Day}.{BirthDate.Month}.{BirthDate.Year}";
        }
    }
    public class Abiturient : Person
    {
        public uint ZNOResult
        {
            get
            {
                return ZNOResult;
            }
            set
            {
                if (ZNOResult <= 200)
                {
                    ZNOResult = value;
                }
            }
        }
        public double SchoolResult
        {
            get
            {
                return SchoolResult;
            }
            set
            {
                if (SchoolResult > 0 && SchoolResult <= 12)
                {
                    SchoolResult = value;
                }
            }
        }
        public string SchoolName
        {
            get
            {
                return SchoolName;
            }
            set
            {
                if (SchoolName != null)
                {
                    SchoolName = value;
                }
            }
        }
        public Abiturient(string lastName, string firstName, DateTime birthDate, 
            uint znoResult, uint basicEducationResult, string schoolName) :
            base(firstName, lastName, birthDate)
        {
            
        }
        public Abiturient(string lastName, string firstName, uint znoResult,
            double basicEducationResult, string schoolName) : base(lastName, firstName)
        {
            
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nZNO Results: {ZNOResult}, School Results: {SchoolResult}, " +
                $"School Name: {SchoolName}";
        }
    }
}