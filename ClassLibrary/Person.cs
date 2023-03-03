namespace ClassLibrary
{
    public class Person
    {
        protected string _firstName ;
        protected string _lastName;
        protected DateTime _dateBirth;

        public string FirstName {
            set {
                if(value != "")
                _firstName = value; 
            }
            get { return _firstName;} 
        }
        public string LastName {
            set{
                if (value != "")
                    _lastName = value;
            }
            get { return _lastName;} 
        }
        DateTime min = new DateTime(1923);
        // макс 2005 для того щоб не могло бути студента від 0 до 16 років
        DateTime max = new DateTime(2006,01,01);
        public DateTime DateBirth {
            set{
                if (value > min && value < max)
                    _dateBirth = value;
            }
            get { return _dateBirth; } 
        }

        public Person() { }
        public Person(string firstName, string secondName)
        {
            _firstName = firstName;
            _lastName = secondName;
        }
        public Person(string firstName, string secondName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = secondName;
            _dateBirth = dateOfBirth;
        }
        public Person(Person person)
        {
            _firstName = person._firstName;
            _lastName = person._lastName;
            _dateBirth = person._dateBirth;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"First-Name : {FirstName}");
            Console.WriteLine($"Last-Name : {LastName}");
            Console.WriteLine($"Date-Of-Birth : {DateBirth.ToString("yyyy/MM/dd")}");
        }
    }
}