using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Teacher : Human
    {
        protected string Posada;
        protected string Kafedra;
        protected string Vnz;

        public Teacher()
        {
            Name = "Name";
            Surname = "Surname";
            Birthday = "Birthday";
            Posada = "Posada";
            Kafedra = "Kafedra";
            Vnz = "Vnz";
        }

        public Teacher(string name, string surname, string birthday, string posada, string kafedra, string vnz)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Posada = posada;
            Kafedra = kafedra;
            Vnz = vnz;
        }

        public Teacher(Teacher obj)
        {
            Name = obj.Name;
            Surname = obj.Surname;
            Birthday = obj.Birthday;
            Posada = obj.Posada;
            Kafedra = obj.Kafedra;
            Vnz = obj.Vnz;
        }

        public string GetPosada()
        {
            return Posada;
        }

        public string GetKafedra()
        {
            return Kafedra;
        }

        public string GetVnz()
        {
            return Vnz;
        }

        public void SetPosada(string posada)
        {
            Posada = posada;
        }

        public void SetKafedra(string kafedra)
        {
            Kafedra = kafedra;
        }

        public void SetVnz(string vnz)
        {
            Vnz = vnz;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Викладач.");
            Console.WriteLine($" Посада: {Posada}");
            Console.WriteLine($" Кафедра: {Kafedra}");
            Console.WriteLine($" ВНЗ: {Vnz}");
        }
    }
}
