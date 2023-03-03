using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Library_User : Person
    {
        protected int _number_Tick_Read;
        protected DateTime _date_Of_Issuse_Tick;
        protected double _subscription_Library;

        public int Number_Tick_Read
        {
            set {
                if (value > 0 && value < 3541) 
                _number_Tick_Read = value;
            }
            get { return _number_Tick_Read;}
        }
        DateTime min = new DateTime(1998);
        DateTime max = new DateTime(2023,03,03);
        public DateTime Date_Of_Issuse_Tick
        {
            set
            {
                if (value > min && value < max)
                {
                    _date_Of_Issuse_Tick = value;
                }
            }
            get { return _date_Of_Issuse_Tick; }
        }
        public double Subscription_Library
        {
            set { 
                if(value>30 && value< 270)
                {
                    _subscription_Library = value;
                }
            }
            get { return _subscription_Library; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Number_Tick_Read : {Number_Tick_Read}");
            Console.WriteLine($"Date_Of_Issuse_Tick : {Date_Of_Issuse_Tick.ToString("yyyy/MM/dd")}");
            Console.WriteLine($"Subscription_Library : {Subscription_Library}.UAH");
        }

        protected Library_User() { }
        public Library_User(int number_Tick_Read, DateTime date_Of_Issuse_Tick, double subscription_Library)
        {
            Number_Tick_Read = number_Tick_Read;
            Date_Of_Issuse_Tick = date_Of_Issuse_Tick;
            Subscription_Library = subscription_Library;
        }

        public Library_User(int number_Tick_Read, DateTime date_Of_Issuse_Tick, double subscription_Library, Person person)
        {
            Number_Tick_Read = number_Tick_Read;
            Date_Of_Issuse_Tick = date_Of_Issuse_Tick;
            Subscription_Library = subscription_Library;
            FirstName = person.FirstName;
            LastName = person.LastName;
            DateBirth = person.DateBirth;
        }

        public Library_User(Library_User libraryUser)
        {
            FirstName = libraryUser.FirstName;
            LastName = libraryUser.LastName;
            DateBirth = libraryUser.DateBirth;
            Number_Tick_Read = libraryUser.Number_Tick_Read;
            Date_Of_Issuse_Tick = libraryUser.Date_Of_Issuse_Tick;
            Subscription_Library = libraryUser.Subscription_Library;
        }
        public Library_User(string firstName,string lastName,DateTime dateOfBirth, int number_Tick_Read,DateTime date_Of_Issuse_Tick, double subscription_Library) 
            :base( firstName, lastName ,dateOfBirth)
        {
            FirstName= firstName;
            LastName= lastName;
            DateBirth= dateOfBirth;
            Number_Tick_Read= number_Tick_Read;
            Date_Of_Issuse_Tick= date_Of_Issuse_Tick;
            Subscription_Library = subscription_Library;
        }
    }
}