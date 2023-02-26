using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher:People
    {
        protected string _Position;
        protected string _Cathedra;
        protected string _NameOfUniversity;
        public Teacher() { }

        public Teacher(string firstName, string lastName, DateTime bdate, 
            string position, string cathedra, string nameOfUniversity) : base(firstName, lastName, bdate)
        {
            _Position = position;
            _Cathedra = cathedra;
            _NameOfUniversity = nameOfUniversity;
        }
        public Teacher(string firstName, string lastName, int day, int month, int year,
            string position, string cathedra, string nameOfUniversity) : base(firstName, lastName, day, month, year)
        {
            _Position = position;
            _Cathedra = cathedra;
            _NameOfUniversity = nameOfUniversity;
        }

        public string Position
        { 
            get { return _Position; } 
            set { _Position = value; }
        }

        public string Cathedra
        {
            get { return _Cathedra; }
            set { _Cathedra = value;}
        }
        public string NameOfUniversity
        {
            get { return _NameOfUniversity; }
            set { _NameOfUniversity = value; }
        }

        public override string ShowInfo()
        {
            return base.ShowInfo() + $"{_Position} {_Cathedra} {_NameOfUniversity}";
        }
    }
}
