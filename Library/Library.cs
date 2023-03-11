using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab7
{
    public class Library : Lyudina
    {
        protected int nomer;
        public int Nomer
        {
            set { nomer = value; }
            get { return nomer; }
        }
        protected string data;
        public string Data
        {
            set { data = value; }
            get { return data; }
        }
        protected int vnesok;
        public int Vnesok
        {
            set { vnesok = value; }
            get { return vnesok; }
        }

        public Library(string name, string surname, int day, int month, int year, int nomer, string data, int vnesok) : base(name, surname, day, month, year)
        {
            Nomer = nomer;
            Data = data;
            Vnesok = vnesok;
        }
        public Library(string name, string surname, int day, int month, int year, string data, int vnesok) : base(name, surname, day, month, year)
        {
            Nomer = 228;
            Data = data;
            Vnesok = vnesok;
        }
        public Library() : base()
        {
            Nomer = 228;
            Data = "28.03.2021";
            Vnesok = 300;
        }
        public Library(Library obj)
        {
            nomer = obj.Nomer;
            data = obj.Data;
            vnesok = obj.Vnesok;
        }

        public override void ReadInfo()
        {
            base.ReadInfo();
            Console.Write("Введіть номер читацького квитка:");
            while (true)
            {
                try
                {
                    Nomer = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
            Console.Write("Введіть дату видачі:");
            Data = Console.ReadLine();
            Console.Write("Введіть розмір щомісячного читацького внеску: ");
            while (true)
            {
                try
                {
                    Vnesok = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Номер читацького квитка: {Nomer}");
            Console.WriteLine($"Дата видачі: {Data}");
            Console.WriteLine($"Розмір щомісячного читацького внеску: {Vnesok}");
        }
    }
}