using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student : Lyudina
    {
        protected int kurs;
        public int Kurs
        {
            set { kurs = value; }
            get { return kurs; }
        }
        protected string grupa;
        public string Grupa
        {
            set { grupa = value; }
            get { return grupa; }
        }
        protected string facultet;
        public string Facultet
        {
            set { facultet = value; }
            get { return facultet; }
        }
        protected string vnz;
        public string Vnz
        {
            set { vnz = value; }
            get { return vnz; }
        }
        public Student(string name, string surname, int day, int month, int year, int kurs, string grupa, string facultet, string vnz) : base(name, surname, day, month, year)
        {
            Kurs = kurs;
            Grupa = grupa;
            Facultet = facultet;
            Vnz = vnz;
        }
        public Student(string name, string surname, int day, int month, int year, string grupa, string facultet, string vnz) : base(name, surname, day, month, year)
        {
            Kurs = 1;
            Grupa = grupa;
            Facultet = facultet;
            Vnz = vnz;
        }
        public Student() : base()
        {
            Kurs = 1;
            Grupa = "ІПЗ";
            Facultet = "ФІКТ";
            Vnz = "ЖДТУ";
        }
        public Student(Student obj)
        {
            kurs = obj.Kurs;
            grupa = obj.Grupa;
            facultet = obj.Facultet;
            vnz = obj.Vnz;
        }

        public override void ReadInfo()
        {
            base.ReadInfo();
            Console.Write("Введіть курс:");
            while (true)
            {
                try
                {
                    Kurs = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
            Console.Write("Введіть групу:");
            Grupa = Console.ReadLine();
            Console.Write("Введіть факультет:");



            Facultet = Console.ReadLine();
            Console.Write("Введіть ВНЗ:");
            Vnz = Console.ReadLine();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Курс: {Kurs}");
            Console.WriteLine($"Назва групи: {Grupa}");
            Console.WriteLine($"Назва факультету: {Facultet}");
            Console.WriteLine($"ВНЗ: {Vnz}");
        }
    }
}
