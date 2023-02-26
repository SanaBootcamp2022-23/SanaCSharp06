using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Teacher : Person
    {
        //Variables
        protected string _universityName;
        protected string _position;
        protected string _chair;

        //Properties
        public string UniversityName
        {
            get => _universityName;
            set => IsCorrectString(ref _universityName, value);
        }
        public string Position
        {
            get => _position;
            set => IsCorrectString(ref _position, value);
        }
        public string Chair
        {
            get => _chair;
            set => IsCorrectString(ref _chair, value);
        }

        //Constructors
        public Teacher()
        {
            _universityName = "None";
            _position = "None";
            _chair = "None";
        }
        public Teacher(Person person)
            : base (person)
        {
            _universityName = "None";
            _position = "None";
            _chair = "None";
        }
        public Teacher(Person person, string universityName)
            :this (person)
        {
            UniversityName = universityName;
        }
        public Teacher(Person person, string universityName, string position)
            :this (person, universityName)
        {
            Position = position;
        }
        public Teacher(Person person, string universityName, string position, string chair)
            : this(person, universityName, position)
        {
            Chair = chair;
        }
        public Teacher(Teacher teacher)
            : base(new Person(teacher._firstName, teacher._lastName, teacher._birthday))
        {
            _universityName = teacher._universityName;
            _position = teacher._position;
            _chair = teacher._chair;
        }

        /// <summary>
        /// Methods
        /// </summary>

        //Basic methods
        public override string ToString()
        {
            string personString = base.ToString();

            return $"{personString}" +
                $"\nUniversity Name: {_universityName}" +
                $"\nPosition: {_position}" +
                $"\nChair: {_chair}";
        }
    }
}
