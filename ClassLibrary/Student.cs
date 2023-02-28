using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Human
    {
        protected int Form;
        protected string group;
        protected string faculty;
        protected string HEI;

        public int _Form
        {
            set
            {
                if (value > 0 && value <= 5)
                {
                    Form = value;
                }
            }
            get { return Form; }
        }

        public string _Group
        {
            set
            {
                if (value != "")
                {
                    group = value;
                }
            }

            get { return group; }
        }

        public string _faculty
        {
            set
            {
                if (value != "")
                {
                    faculty = value;
                }
            }

            get { return faculty; }
        }

        public string _HEI
        {
            set
            {
                if (value != "")
                {
                    HEI = value;
                }
            }

            get { return HEI; }
        }


        public Student(string name, string surname, int Form, string group, string faculty, string HEI) : base(name, surname)
        {
            this.Form = Form;
            this.group = group;
            this.faculty = faculty;
            this.HEI = HEI;
        }

        public Student(string name, string surname, int day, int month, int year, int Form, string group, string faculty, string HEI) : base(name, surname, day, month, year)
        {
            this.Form = Form;
            this.group = group;
            this.faculty = faculty;
            this.HEI = HEI;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Студент");
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
            Console.WriteLine($"Курс: {Form}");
            Console.WriteLine($"Група: {group}");
            Console.WriteLine($"Факультет: {faculty}");
            Console.WriteLine($"ВНЗ: {HEI}");
        }
    }
}
