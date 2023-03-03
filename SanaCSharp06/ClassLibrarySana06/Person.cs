namespace ClassLibrarySana06
{
    public class Person
    {
        protected string firstname;
        protected string lastname;
        protected int dayofbirth;
        protected int mounthofbith;
        protected int yearofbirth;

        private Person person;

        public Person(Person person, string firstname, string lastname, int dayofbirth, int mounthofbith, int yearofbirth, int dayOfBirth, int montthOfBirth, int yearOfBirth) : this(firstname, lastname, dayofbirth, mounthofbith, yearofbirth)
        {
            this.person = person;
            person.Firstname = firstname;
            person.Lastname = lastname;
            person.DayOfBirth = dayOfBirth;
            person.MontthOfBirth = montthOfBirth;
            person.YearOfBirth = yearOfBirth;
        }

       
        public string Firstname { get { return firstname; } protected set { firstname = value; } }
        public string Lastname { get { return lastname; } protected set { lastname = value; } }
        public int DayOfBirth { get { return dayofbirth; } set { if (value > 0 && value < 32) dayofbirth = value; } }
        public int MontthOfBirth { get { return mounthofbith; } set { if (value > 0 && value < 13) mounthofbith = value; } }
        public int YearOfBirth { get { return yearofbirth; } set { if (value > 1900 && value < 2023) yearofbirth = value; } }


        public Person(string firstname, string lastname, int dayofbirth, int mounthofbith, int yearofbirth)
        {
            Firstname = firstname;
            Lastname = lastname;
            DayOfBirth = dayofbirth;
            MontthOfBirth = mounthofbith;
            YearOfBirth = yearofbirth;
        }
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public Person()
        {
            firstname = "unset";
            lastname = "unset";
            dayofbirth = 0;
            mounthofbith = 0;
            yearofbirth = 0;
        }

        public virtual void ShowInfo()
        {
            Console.Write($"{lastname} {firstname} {dayofbirth:D2}.{mounthofbith:D2}.{yearofbirth} ");
        }
    
    }
}