using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp6
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Birth { get; set; }

        public Person(){}

        public Person(string name,string surName,string birth) {
            Name=name;
            SurName=surName;
            Birth = birth;
        }
        public Person(string name, string surName)
        {
            Name = name;
            SurName = surName;
            
        }
        public virtual void ShowInfo()
        {
            string info = $"Ім'я: {Name};\nПрізвище: {SurName};";
            info += Birth == "" ? "" : $"\nДата народження: {Birth}";
            Console.WriteLine(info);
        }
    }
}
