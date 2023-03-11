using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Abiturient : Lyudina
    {
        protected int zno;
        public int Zno
        {
            set { zno = value; }
            get { return zno; }
        }
        protected int atestat;
        public int Atestat
        {
            set { atestat = value; }
            get { return atestat; }
        }
        protected string shkola;
        public string Shkola
        {
            set { shkola = value; }
            get { return shkola; }
        }
        public Abiturient(string name, string surname, int day, int month, int year, int zno, int atestat, string shkola) : base(name, surname, day, month, year)
        {
            Zno = zno;
            Atestat = atestat;
            Shkola = shkola;
        }
        public Abiturient() : base()
        {
            zno = 1;
            atestat = 1;
            shkola = "School";
        }
        public Abiturient(string name, string surname, int day, int month, int year, string shkola) : base(name, surname, day, month, year)
        {
            Zno = 1;
            Atestat = 1;
            Shkola = shkola;
        }
        public Abiturient(Abiturient obj)
        {
            zno = obj.Zno;
            atestat = obj.Atestat;
            shkola = obj.Shkola;
        }

        public override void ReadInfo()
        {
            base.ReadInfo();
            Console.Write("Введіть кількість балів сертифікатів ЗНО:");
            while (true)
            {
                try
                {
                    Zno = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
            Console.Write("Введіть кількість балів за документ про освіту:");
            while (true)
            {
                try
                {
                    Atestat = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
            Console.Write("Введіть назву загальноосвітнього навчального закладу:");
            Shkola = Console.ReadLine();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Кількість балів сертифікатів ЗНО: {Zno}");
            Console.WriteLine($"Кількість балів за документ про освіту: {Atestat}");
            Console.WriteLine($"Назва загальноосвітнього навчального закладу: {Shkola}");
        }
    }
}

