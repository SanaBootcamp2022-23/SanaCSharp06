using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Entrant : People
    {
        protected string _NameOfSchool;
        protected double _PointOfcertificate;
        protected Dictionary<string, double> _ZNOPoints;

        public Entrant() { }

        public Entrant(string firstName, string lastName, DateTime bdate, string nameOfSchool, double pointOfcertificate, Dictionary<string, double> zNOPoints) : base(firstName, lastName, bdate)
        {
            _NameOfSchool = nameOfSchool;
            _PointOfcertificate = pointOfcertificate;
            _ZNOPoints = zNOPoints;
        }

        public Entrant(string firstName, string lastName, int day, int month, int year, string nameOfSchool, double pointOfcertificate, Dictionary<string, double> zNOPoints) : base(firstName, lastName, day, month, year)
        {
            _NameOfSchool = nameOfSchool;
            _PointOfcertificate = pointOfcertificate;
            _ZNOPoints = zNOPoints;
        }

        public string NameOfSchool
        {
            get { return _NameOfSchool; }
            set { _NameOfSchool = value; }
        }

        public double PointOfcertificate
        {
            get { return _PointOfcertificate; }
            set { _PointOfcertificate = value; }
        }

        public Dictionary<string, double> ZNOPoints
        {
            get { return _ZNOPoints; }
            set { _ZNOPoints = value; }
        }

        public override string ShowInfo()
        {
            return base.ShowInfo() + $"\n{_NameOfSchool} {_PointOfcertificate}\n" + ZNOpointsToString();
        }

        private string ZNOpointsToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, double> entry in ZNOPoints)
            {
                sb.Append(entry.Key);
                sb.Append(' ');
                sb.Append(entry.Value);
                sb.Append("\n");
            }

            return sb.ToString();
        }

    }
}
