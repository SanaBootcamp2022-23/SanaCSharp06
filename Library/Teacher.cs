using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Teacher : Lyudina
    {
        protected string posada;
        public string Posada
        {
            set { posada = value; }
            get { return posada; }
        }
        protected string kafedra;
        public string Kafedra
        {
            set { kafedra = value; }
            get { return kafedra; }
        }
        protected string vnz;
        public string Vnz
        {
            set { vnz = value; }
            get { return vnz; }
        }
        public Teacher(string name, string surname, int day, int month, int year, string posada, string kafedra, string vnz) : base(name, surname, day, month, year)
        {
            Posada = posada;
            Kafedra = kafedra;
            Vnz = vnz;
        }
        public Teacher(string name, string surname, int day, int month, int year, string kafedra, string vnz) : base(name, surname, day, month, year)
        {
            Posada = "Dekan";
            Kafedra = kafedra;
            Vnz = vnz;
        }
        public Teacher() : base()
        {
            Posada = "Rektor";
            Kafedra = "Ki i kb";
            Vnz = "Polytech";
        }
        public Teacher(Teacher obj)
        {
            posada = obj.Posada;
            kafedra = obj.Kafedra;
            vnz = obj.Vnz;
        }
        public override void ReadInfo()
        {
            base.ReadInfo();
            Console.Write("Введіть посаду:");
            Posada = Console.ReadLine();
            Console.Write("Введіть кафедру:");
            Kafedra = Console.ReadLine();
            Console.Write("Введіть ВНЗ:");
            Vnz = Console.ReadLine();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Назва посади: {Posada}");
            Console.WriteLine($"Назва кафедри: {Kafedra}");
            Console.WriteLine($"Назва ВНЗ: {Vnz}");
        }
    }
}
