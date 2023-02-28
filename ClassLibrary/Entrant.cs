using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Entrant : Human
    {
        protected double ZNOmark;
        protected double SCHOOLmark;
        protected string SchoolName;

        public double _ZNOmark
        {
            set
            {
                if (value > 0 && value < 200)
                {
                    ZNOmark = value;
                }
            }
            get { return ZNOmark; }
        }

        public double _SCHOOLmark
        {
            set
            {
                if (value > 0 && value < 200)
                {
                    SCHOOLmark = value;
                }
            }
            get { return SCHOOLmark; }
        }

        public string _SchoolName
        {
            set
            {
                if (value != "")
                {
                    SchoolName = value;
                }
            }
            get { return SchoolName; }
        }

        public Entrant(string name, string surname, int day, int month, int year, double ZNOmark, string group, double SCHOOLmark, string SchoolName) : base(name, surname, day, month, year)
        {
            this.ZNOmark = ZNOmark;
            this.SCHOOLmark = SCHOOLmark;
            this.SchoolName = SchoolName;
        }

        public Entrant(int ZNOmark, int SCHOOLmark, string SchoolName, string name, string surname) : base(name, surname)
        {
            this.ZNOmark = ZNOmark;
            this.SCHOOLmark = SCHOOLmark;
            this.SchoolName = SchoolName;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Абітурієнт");
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
            Console.WriteLine($"Кількість балів сертифікату ЗНО: {ZNOmark}");
            Console.WriteLine($"Кількість балів за документ про освіту: {SCHOOLmark}");
            Console.WriteLine($"Назва загальноосвітнього навчального закладу: {SchoolName}");
        }
    }
}
