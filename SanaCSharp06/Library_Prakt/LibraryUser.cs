using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Prakt
{
    public class LibraryUser : Human
    {
        protected int id;
        public int Id {
            get { return id; }
            set { if (value >= 0) id = value; }
        }

        protected DateTime dateOfIssue;
        public DateTime DateOfIssue 
        { 
            get { return dateOfIssue; }
            set { dateOfBirthday = value; }
        }

        protected float priceOfMembership;
        public float PriceOfMembership
        {
            get { return priceOfMembership; }
            set { if (value >= 0) priceOfMembership = value; }
        }

        public LibraryUser (string name, string surname, DateTime birthday, int id, DateTime date, float price)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirthday = birthday;
            this.id = id;
            this.dateOfIssue = date;
            this.priceOfMembership = price;
        }

        public LibraryUser (int id, DateTime date, float price)
        {
            this.id = id;
            this.dateOfIssue = date;
            this.priceOfMembership = price;
        }

        public LibraryUser(Human person, int id, DateTime date, float price) : this(person.Name, person.Surname, person.DateOfBirthday,id,date,price)  { }

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Id: {this.id}");
            Console.WriteLine($"Date of issue: {this.dateOfIssue.Day}.{this.dateOfIssue.Month}.{this.dateOfIssue.Year}");
            Console.WriteLine($"Price of membership: {this.priceOfMembership}$");
            Console.WriteLine();

        }

    }
}
