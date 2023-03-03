namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        public static int CardNumber { get; set; }
        public DateTime DateofIssue { get; }
        public decimal MonthlyFee { get; set; }

        public LibraryUser(decimal monthlyFee,
            string firstName, string lastName, DateTime dateOfBirth)
            : base(firstName, lastName, dateOfBirth)
        {
            CardNumber++;
            DateofIssue = DateTime.Now.Date;
            MonthlyFee = monthlyFee;
        }

        public LibraryUser(Person person, decimal monthlyFee)
            : base(person.FirstName, person.LastName, person.DateOfBirth)
        {
            if (person is Student | person is Teacher)
            {
                MonthlyFee = 0;
            }
            else
            {
                MonthlyFee = monthlyFee;
            }

            CardNumber++;
            DateofIssue = DateTime.Now.Date;
        }

        public LibraryUser()
        {
        }

        public virtual void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Номер картки: {0}", CardNumber);
            Console.WriteLine("Дата видачі: {0}", DateofIssue);
            Console.WriteLine("Помісячний внесок: {0}", MonthlyFee);
        }
    }
}