using DocumentFormat.OpenXml.Wordprocessing;
using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Abiturient : Person
    {
        public int ZNO { get; set; }
        public int Atestat { get; set; }
        public string SchoolName { get; set; }
        public Abiturient(string name, string lastName, Date birthDate, 
            int zNO, int atestat, string schoolName) : base(name, lastName, birthDate)
        {
            ZNO = zNO;
            Atestat = atestat;
            SchoolName = schoolName;
        }
        public Abiturient() : base()
        {
            ZNO = 0;
            Atestat = 0;
            SchoolName = "None";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(
               $"Резульат ЗНО: {ZNO}\n" +
               $"Бал атестата: {Atestat}\n" +
               $"Назва школи: {SchoolName}\n");
        }
    }
}
