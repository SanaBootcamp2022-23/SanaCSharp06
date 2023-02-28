using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Teacher:Person
    {
        protected string Position;
        protected string Cathedra;
        protected string NameOfInstitution;

        public Teacher(string name, string surname, DateTime dateofbirth, string position, string cathedra, string nameOfInstitution):this(name,surname,dateofbirth,position,cathedra)
        {
            this.NameOfInstitution = nameOfInstitution;
        }
        public Teacher(string name, string surname, DateTime dateofbirth, string position,string cathedra) : base(name, surname, dateofbirth)
        {
            this.Position = position;
            this.Cathedra = cathedra;
            this.NameOfInstitution = "Житомирська політехніка";

        }
      
        public string PositionProperty
        {
            get { return Position; }
            set { Position = value; }
        }

        public string CathedraProperty
        {
            get { return Cathedra; }
            set { Cathedra = value; }
        }
        public string NameOfInstitutionProperty
        {
            get { return NameOfInstitution; }
            set { NameOfInstitution = value; }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Ім'я -> {Name} // прізвище -> {Surname} // дата народження -{DateOfBirth} // посада ->{Position} // кафедра ->{Cathedra} // вищий навчальний заклад -{NameOfInstitution}\n");
        }
    }
}
