namespace ClassLibrary
{
    public abstract class Person
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime dateofbirth { get; set; }
        public Person() 
        {
            firstname = "";
            lastname = "";
        }
        public Person( string firstname, string lastname, DateTime dateofbirth) 
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dateofbirth = dateofbirth;
        }
        public Person(string firstname, string lastname) 
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public virtual string ShowInfo()
        {
            return $"Ім'я: {firstname}\nПрізвище: {lastname}\nДата народження: {dateofbirth.Day}.{dateofbirth.Month}.{dateofbirth.Year}";
        }
    }
}