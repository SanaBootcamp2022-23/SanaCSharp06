using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Tutor : Human
    {
        protected string position;
        protected string chair;
        protected string HEI;

        public string _position
        {
            set { position = value; }
            get { return position; }
        }

        public string _chair
        {
            set { chair = value; }
            get { return chair; }
        }
        public string _HEI
        {
            set { chair = value; }
            get
            {
                return chair;
            }
        }

        public Tutor(string name, string surname, string position, string chair, string HEI) : base(name, surname)
        {
            this.position = position;
            this.chair = chair;
            this.HEI = HEI;
        }

        public Tutor(string name, string surname, int day, int month, int year, string position, string chair, string HEI) : base(name, surname, day, month, year)
        {
            this.position = position;
            this.chair = chair;
            this.HEI = HEI;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Викладач");
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
            Console.WriteLine($"Посада: {position}");
            Console.WriteLine($"Факультет: {chair}");
            Console.WriteLine($"ВНЗ: {HEI}");
        }
    }
}
