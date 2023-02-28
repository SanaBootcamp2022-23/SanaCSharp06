using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Prakt
{

    public class Teacher : Human
    {
        protected string position;
        public string Position
        {
            get { return position; }
            set { if (value != null) position = value; }
        }

        protected string cathedra;
        public string Cathedra
        {
            get { return cathedra; }
            set { if (value != null) cathedra = value; }
        }

        protected string nameOfUniversity;
        public string NameOfUniversity
        {
            get { return nameOfUniversity; }
            set { if (value != null) nameOfUniversity = value; }
        }

        public Teacher (string name, string surname, DateTime birthday, string position, string cathedra, string university)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirthday = birthday;
            this.position = position;
            this.cathedra = cathedra;
            this.nameOfUniversity = university;
        }

        public Teacher (string position, string cathedra, string university)
        {
            this.position = position;
            this.cathedra = cathedra;
            this.nameOfUniversity = university;
        }

        public Teacher (Human person, string position, string cathedra, string university) : this(person.Name, person.Surname, person.DateOfBirthday, position, cathedra, university) { }

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {this.position}");
            Console.WriteLine($"Cathedra: {this.cathedra}");
            Console.WriteLine($"University: {this.nameOfUniversity}");
            Console.WriteLine();

        }
    }
}
