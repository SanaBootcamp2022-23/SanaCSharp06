using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Applicant : Human
    {
        protected int Zno1;
        protected int Zno2;
        protected int Zno3;
        protected float DocProOsv;
        protected string NameZonz;

        public Applicant()
        {
            Name = "Name";
            Surname = "Surname";
            Birthday = "Birthday";
            Zno1 = 100;
            Zno2 = 100;
            Zno3 = 100;
            DocProOsv = 1;
            NameZonz = "NameZonz";
        }

        public Applicant(string name, string surname, string birthday, int zno1, int zno2, int zno3, float docProOsv, string nameZonz)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Zno1 = zno1;
            Zno2 = zno2;
            Zno3 = zno3;
            DocProOsv = docProOsv;
            NameZonz = nameZonz;
        }

        public Applicant(Applicant obj)
        {
            Name = obj.Name;
            Surname = obj.Surname;
            Birthday = obj.Birthday;
            Zno1 = obj.Zno1;
            Zno2 = obj.Zno2;
            Zno3 = obj.Zno3;
            DocProOsv = obj.DocProOsv;
            NameZonz = obj.NameZonz;
        }

        public int GetZno1()
        {
            return Zno1;
        }
        public int GetZno2()
        {
            return Zno2;
        }
        public int GetZno3()
        {
            return Zno3;
        }
        public float GetDocProOsv()
        {
            return DocProOsv;
        }
        public string GetNameZonz()
        {
            return NameZonz;
        }

        public void SetZno1(int zno1)
        {
            Zno1 = zno1;
        }
        public void SetZno2(int zno2)
        {
            Zno2 = zno2;
        }
        public void SetZno3(int zno3)
        {
            Zno3 = zno3;
        }
        public void SetDocProOsv(float docProOsv)
        {
            DocProOsv = docProOsv;
        }
        public void SetNameZonz(string nameZonz)
        {
            NameZonz = nameZonz;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Абітурієнт.");
            Console.WriteLine($" Бали за ЗНО: {Zno1}, {Zno2}, {Zno3},");
            Console.WriteLine($" Бал документа про освіту: {DocProOsv}");
            Console.WriteLine($" Назва загальноосвітнього навчального закладу: {NameZonz}");
        }
    }
}
