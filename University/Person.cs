namespace University
{
    public class Person {
        protected string _firstName = "Undefined";
        protected string _lastName = "Undefined";
        protected DateOnly _dateOfBirth;

        public string FirstName { get => _firstName; set => _firstName = value  ?? "Undefined"; }
        public string LastName { get => _lastName; set => _lastName = value  ?? "Undefined"; }
        public DateOnly DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        
        public Person(string firstName, string lastName) {
           this.FirstName = firstName;
           this.LastName = lastName;
        }

        public Person(string firstName, string lastName, DateOnly dateOfBirth) : this(firstName, lastName) {
            this.DateOfBirth = dateOfBirth;
        }

        public virtual void ShowInfo() {
            Console.WriteLine("Person: ");
            Console.WriteLine($"  First name: {this.FirstName}");
            Console.WriteLine($"  Last name: {this.LastName}");
            Console.WriteLine($"  Date of birth: {this.DateOfBirth}");
        }
    }
}
