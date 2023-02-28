using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Human
    {
        protected string name;
        protected string surname;

        protected Date date;

        public string _name
        {
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
            get { return name; }
        }

        public string _surname
        {
            set
            {
                if (value != "")
                {
                    surname = value;
                }
            }
            get { return surname; }
        }

        public int _day
        {
            set
            {
                if (value > 0 && value <= 31)
                {
                    date.day = value;
                }
            }
            get { return date.day; }
        }

        public int _month
        {
            set
            {
                if (value > 0 && value <= 12)
                {
                    date.month = value;
                }
            }
            get { return date.month; }
        }

        public int _year
        {
            set
            {
                if (value != 0 && value > 1900)
                {
                    date.year = value;
                }
            }
            get { return date.year; }
        }

        public Human(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public Human(string name, string surname, int day, int month, int year) : this(name, surname)
        {
            date.day = day;
            date.month = month;
            date.year = year;
        }

        public Human(Human human)
        {
            name = human.name;
            surname = human.surname;
            date.day = human.date.day;
            date.month = human.date.month;
            date.year = human.date.year;
        }

        public virtual void ShowInfo()
        {
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
        }
    }
}
