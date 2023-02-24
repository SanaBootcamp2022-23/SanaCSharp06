namespace OOP2
{
    public class Person
    {

        protected string FirstName;
        protected string LastName;
        protected string BirthDate;
        public Person()
        {
            FirstName = "John";
            LastName = "Smith";
            BirthDate = "Unknown";
        }
        public Person(string firstName, string lastName, uint birthDay, uint birthMonth, uint birthYear)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            SetBirthDate(birthDay, birthMonth, birthYear);
        }
        public Person(string lastName, string firstName)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
            BirthDate = "Unknown";
        }
        public string GetFirstName()
        {
            return $"{FirstName}";
        }
        public string GetLastName()
        {
            return $"{LastName}";
        }
        public string GetBirthDate()
        {
            return $"{BirthDate}";
        }
        public void SetFirstName(string newFirstName)
        {
            if (newFirstName != null)
            {
                this.FirstName = newFirstName;
            }
            else throw new Exception("Invalid First Name");
        }
        public void SetLastName(string newLastName)
        {
            if (newLastName != null)
            {
                this.LastName = newLastName;
            }
            else throw new Exception("Invalid Last Name");
        }
        public void SetBirthDate(uint birthDay, uint birthMonth, uint birthYear)
        {
            if (birthYear < 2023)
            {
                if (birthMonth <= 8)
                {
                    if (birthMonth == 2)
                    {

                        if (birthYear % 4 == 0)
                        {
                            if (birthDay <= 29)
                            {
                                this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                            }
                            else throw new Exception("Invalid Day value");
                        }else if (birthDay <= 28)
                        {
                            this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                        }
                        else throw new Exception("Invalid Day value");

                    }
                    else if (birthMonth % 2 == 1 || birthMonth == 8)
                    {
                        if (birthDay <= 31)
                        {
                            this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                        }
                        else
                            throw new Exception("Invalid Day value");
                    }
                    else if (birthDay <= 30)
                    {
                        this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                    }
                    else
                        throw new Exception("Invalid Day value");
                }
                else if (birthMonth % 2 == 0)
                {
                    if (birthDay <= 31)
                    {
                        this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                    }
                    else
                        throw new Exception("Invalid Day value");
                }
                else if (birthDay <= 30)
                {
                    this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                }
                else throw new Exception("Invalid Month Value");
            }
            else throw new Exception("Invalid Year Value");
        }
        public virtual string ShowInfo()
        {
            return $"Name:{LastName} {FirstName} Born:{BirthDate}";
        }
    }
    public class Abiturient : Person
    {
        protected uint znoResult;
        protected double basicEducationResult;
        protected string schoolName;
        public Abiturient()
        {
            FirstName = "John";
            LastName = "Smith";
            BirthDate = "Unknown";
            znoResult = 0;
            basicEducationResult = 0;
            schoolName = "Unknown";
        }
        public Abiturient(string lastName, string firstName, uint birthDay, uint birthMonth,
            uint birthYear, uint znoResult, uint basicEducationResult, string schoolName) :
            base(firstName, lastName, birthDay, birthMonth, birthYear)
        {
            SetZNOResult(znoResult);
            SetSchoolName(schoolName);
            SetBasicEducationResult(basicEducationResult);
        }
        public Abiturient(string lastName, string firstName, uint znoResult, 
            double basicEducationResult, string schoolName):base(lastName, firstName)
        {
            SetZNOResult(znoResult);
            SetSchoolName(schoolName);
            SetBasicEducationResult(basicEducationResult);
        }

        public uint GetZNOResult()
        {
            return znoResult;
        }
        public double GetBasicEducationResult()
        {
            return basicEducationResult;
        }
        public string GetSchoolName()
        {
            return $"{schoolName}";
        }
        public void SetZNOResult(uint znoResult)
        {
            if (znoResult <= 200)
            {
                this.znoResult = znoResult;
            }
            else throw new Exception("Invalid ZNO Result value");
        }
        public void SetBasicEducationResult(double basicEducationResult)
        {
            if (basicEducationResult > 0 && basicEducationResult <= 12)
            {
                this.basicEducationResult = basicEducationResult;
            }
            else throw new Exception("Invalid Basic Education Result value");
        }
        public void SetSchoolName(string schoolName)
        {
            if (schoolName != null)
            {
                this.schoolName = schoolName;
            }
            else throw new Exception("Invalid School Name value");
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nZNO Results: {znoResult}, School Results: {basicEducationResult}, " +
                $"School Name: {schoolName}";
        }
    }
}