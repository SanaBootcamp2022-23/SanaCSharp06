using System.Runtime.CompilerServices;

namespace MyLibrary
{
    public class Person
    {
        //Variables
        protected string _firstName;
        protected string _lastName;
        protected DateTime _birthday;

        //Properties
        public string FirstName
        {
            get => _firstName;
            set => IsCorrectString(ref _firstName, value);
        }
        public string LastName
        {
            get => _lastName;
            set => IsCorrectString(ref _lastName, value);
        }
        public DateTime Birthday
        {
            get => _birthday;
            set => _birthday = value;
        }

        //Contructors
        public Person() {
            _firstName = "None";
            _lastName = "None";
            _birthday = new DateTime();
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            _birthday = DateTime.Now;
        }
        public Person(string firstName, string lastName, DateTime birthday)
            : this(firstName, lastName)
        {
            Birthday = birthday;
        }
        public Person(Person person)
        {
            _firstName = person.FirstName;
            _lastName = person.LastName;
            _birthday = person.Birthday;
        }

        /// <summary>
        /// Methods
        /// </summary>

        //Basic methods
        public override string ToString()
        {
            return $"First Name: {_firstName}" +
                 $"\nLast Name: {_lastName}" +
                 $"\nDate of birthday: {_birthday}";
        }

        //Output methods
        public virtual string ShowInfo()
        {
            string callback = $"{GetType().Name}:";

            foreach (string line in ToString().Split('\n'))
                callback += $"\n\t{line}";

            return callback;
        }

        //Validate methods
        protected virtual void IsCorrectString(ref string var, string value, [CallerMemberName] string? PropertyName = null)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(PropertyName), $"{PropertyName} cannot be null or empty");
            
            if (value != null && value != var) var = value;
        }
        protected virtual void IsCorrectDobule(ref double var, double value, double minVal, double maxVal, [CallerMemberName] string PropertyName = null)
        {
            if (value < minVal || value > maxVal)
                throw new ArgumentNullException(nameof(PropertyName), $"{PropertyName} cannot be less then {minVal} and greater then {maxVal}");

            if(var != value) var = value;
        }
    }
}