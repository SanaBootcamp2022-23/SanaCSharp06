using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Human
    {
        protected int ID;
        protected Date Date;
        protected double monthlyPaidCash;

        public int _ID
        {
            set
            {
                ID = value;
            }
            get { return ID; }
        }

        protected double _MPC
        {
            set
            {
                if (value > 0)
                {
                    monthlyPaidCash = value;
                }
            }

            get { return monthlyPaidCash; }
        }

        public LibraryUser(string name, string surname, int day, int month, int year) : base(name, surname)
        {
            Date.day = day;
            Date.month = month;
            Date.year = year;
        }
        public LibraryUser(string name, string surname, int bday, int bmonth, int byear, int day, int month, int year, double MPC) : base(name, surname, bday, bmonth, byear)
        {
            Date.day = day;
            Date.month = month;
            Date.year = year;
            monthlyPaidCash = MPC;
        }

        public LibraryUser(string name, string surname, double MPC) : base(name, surname)
        {
            monthlyPaidCash = MPC;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Відвідувач бібліотеки");
            Console.WriteLine($"Прізвище:{surname}");
            Console.WriteLine($"Ім'я:{name}");
            if (date.day == 0 || date.month == 0 || date.year == 0)
            {
                Console.WriteLine("Дата народження невідома");
            }
            else
            {

                Console.WriteLine($"Дата народження:{date.day}.{date.month}.{date.year}");
            }
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Дата видачі:{Date.day}.{Date.month}.{Date.year}");
            Console.WriteLine($"Розмір щомісячного читацького внеску: {monthlyPaidCash}");
        }

    }
}
