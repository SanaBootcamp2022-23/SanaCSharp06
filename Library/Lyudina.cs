using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Lyudina
    {
        protected string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        protected string surname;
        public string Surname
        {
            set { surname = value; }
            get { return surname; }
        }
        protected int day;
        public int Day
        {
            set { day = value; }
            get { return day; }
        }
        protected int month;
        public int Month
        {
            set { month = value; }
            get { return month; }
        }
        protected int year;
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        public Lyudina(string name, string surname, int day, int month, int year)
        {
            Name = name;
            Surname = surname;
            Day = day;
            Month = month;
            Year = year;
        }
        public Lyudina()
        {
            name = "Дмитро";
            surname = "Федорович";
            day = 3;
            month = 12;
            year = 2003;
        }
        public Lyudina(int day, int month)
        {
            name = "Дмитро";
            surname = "Федорович";
            Day = day;
            Month = month;
            year = 2003;
        }
        public Lyudina(Lyudina obj)
        {
            name = obj.Name;
            surname = obj.Surname;
            day = obj.Day;
            month = obj.Month;
            year = obj.Year;
        }

        public virtual void ReadInfo()
        {
            Console.Write("Введіть ім'я:");
            Name = Console.ReadLine();
            Console.Write("Введіть прізвище:");
            Surname = Console.ReadLine();
            Console.Write("Введіть день народження:");
            while (true)
            {
                try
                {
                    Day = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
            Console.Write("Введіть місяць народження:");
            while (true)
            {
                try
                {
                    Month = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
            Console.Write("Введіть рік народження:");
            while (true)
            {
                try
                {
                    Year = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {Name}");
            Console.WriteLine($"Прізвище: {Surname}");
            Console.WriteLine($"Дата народження: {Day}.{Month}.{Year}");
        }

    }
}
