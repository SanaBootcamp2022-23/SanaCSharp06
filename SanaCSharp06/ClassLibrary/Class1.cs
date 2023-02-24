namespace OOP2
{
    public class Person
    {

        protected string FirstName;
        protected string LastName;
        protected string BirthDate;
        public Person()
        {
            this.FirstName = "John";
            this.LastName = "Smith";
            this.BirthDate = "Unknown";
        }
        public Person(string firstName, string lastName, uint birthDay, uint birthMonth, uint birthYear)
        {
            this.SetFirstName(firstName);
            this.SetLastName(lastName);
            this.SetBirthDate(birthDay, birthMonth, birthYear);
        }
        public Person(string lastName, string firstName)
        {
            this.SetFirstName(firstName);
            this.SetLastName(lastName);
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
                        if (birthDay <= 29)
                            this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                    }
                    else if (birthMonth % 2 == 1 || birthMonth == 8)
                    {
                        if (birthDay <= 31)
                        {
                            this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                        }
                    }
                    else if (birthDay <= 30)
                    {
                        this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                    }
                }
                else if (birthMonth % 2 == 0)
                {
                    if (birthDay <= 31)
                    {
                        this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                    }
                }
                else if (birthDay <= 30)
                {
                    this.BirthDate = $"{birthDay}.{birthMonth}.{birthYear}";
                }
            }
        }
        public virtual string ShowInfo()
        {
            return $"Name:{LastName} {FirstName} Born:{BirthDate}";
        }
    }
}