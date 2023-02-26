using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Entrant : Person
    {
        //Variables
        protected double _pointsBySchool;
        protected double _pointsByZNO;
        protected string _schoolName;

        //Properties
        public string SchoolName
        {
            get => _schoolName;
            set => IsCorrectString(ref _schoolName, value);
        }
        public double PointsBySchool
        {
            get => _pointsBySchool;
            set => IsCorrectDobule(ref _pointsBySchool, value, 0, 100);
        }
        public double PointsByZNO
        {
            get => _pointsByZNO;
            set => IsCorrectDobule(ref _pointsByZNO, value, 0, 100);
        }

        //Constructors
        public Entrant()
        {
            _schoolName = "None";
            _pointsBySchool = 0.0;
            _pointsByZNO = 0.0;
        }
        public Entrant(Person person)
            : base(person)
        {
            _schoolName = "None";
            _pointsBySchool = 0.0;
            _pointsByZNO = 0.0;
        }
        public Entrant(Person person, string schoolName, double pointsBySchool)
            :this (person)
        {
            SchoolName = schoolName;
            PointsBySchool = pointsBySchool;
            _pointsByZNO = 0;
        }
        public Entrant(Person person, string schoolName, double pointsBySchool, double pointsByZNO)
            : this(person, schoolName, pointsBySchool)
        {
            PointsByZNO = pointsByZNO;
        }
        public Entrant(Entrant entrant) 
            : base (entrant._firstName, entrant._lastName, entrant._birthday)
        {
            _schoolName = entrant.SchoolName;
            _pointsBySchool = entrant.PointsBySchool;
            _pointsByZNO = entrant.PointsByZNO;
        }

        /// <summary>
        /// Methods
        /// </summary>
        
        //Basic methods
        public override string ToString()
        {
            string personString = base.ToString();

            return $"{personString}" +
                $"\nSchool name: {_schoolName}" +
                $"\nPoints by School: {_pointsBySchool}" +
                $"\nPoints by ZNO: {_pointsByZNO}";
        }
    }
}
