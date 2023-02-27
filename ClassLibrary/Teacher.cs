using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        public string position { get; set; }
        
        public string university { get; set; }       
        public string departament { get; set; }       
        public Teacher(string firstname,string lastname, DateTime dateofbirth, string position, string university, 
                       string departament) : base(firstname,lastname, dateofbirth)
        {
            this.position = position;
            this.university = university;
            this.departament = departament;
        }
        public Teacher(Person person, string position, string university,
                       string departament) : this(person.firstname, person.lastname, person.dateofbirth, position, university, departament)
        { }
        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\nУніверситет: {university} \nПосада: {position} \nКафедра: {departament}";
        }
    }
}