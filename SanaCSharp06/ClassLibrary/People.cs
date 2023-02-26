namespace ClassLibrary
{
    public class People
    {
        protected string _FirstName;
        protected string _LastName;
        protected DateTime _BirthDate;


        public People(string firstName, string lastName)
        {
            _FirstName = firstName;
            _LastName = lastName;
        }

        public People(string firstName, string lastName, DateTime birthDate) : this(firstName, lastName)
        {
            _BirthDate = birthDate;
        }

        public People(string firstName, string lastName, int day, int month, int year) : this(firstName, lastName)
        {
            _BirthDate = new DateTime(year, month, day);
        }

        public string FirstName
        { 
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }

        public DateTime BirthDate
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }

        public virtual string ShowInfo()
        {
            return $" {_FirstName} {_LastName} {_BirthDate.ToShortDateString()}";
        }
    }
}