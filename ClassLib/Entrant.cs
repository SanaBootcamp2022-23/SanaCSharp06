
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLib
{
    public class Entrant : Person
    {
        public int ZNO { get; set; }
        public int Atestat { get; set; }
        public string School { get; set; }
        public Entrant(string name, string surname, string birthDate, int zno, int atestat, string school) : base(name, surname,birthDate)
        {
            ZNO = zno;
            Atestat = atestat;
            School = school;
        }
        public Entrant(string name, string surname, int atestat, string school) : base(name,surname)
        {
            Atestat = atestat;
            School = school;
        }
        public Entrant()
        {

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {Name}\nПрізвище: {Surname}\nКількість балів сертифікатів ЗНО: {ZNO}\nКількість балів атестату: {Atestat}\nНазва навчального закладу: {School}\n");
        }
    }
}
