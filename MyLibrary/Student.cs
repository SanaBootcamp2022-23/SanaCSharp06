namespace MyLibrary
{
    public class Student : Entrant
    {
        //Variables
        protected string _universityName;
        protected double _course;
        protected string _faculty;
        protected string _group;

        //Properties
        public string UniversityName
        {
            get => _universityName;
            set => IsCorrectString(ref _universityName, value);
        }
        public double Course
        {
            get => _course;
            set => IsCorrectDobule(ref _course, value, 1, 4);
        }
        public string Faculty
        {
            get => _faculty;
            set => IsCorrectString(ref _faculty, value);
        }
        public string Group
        {
            get => _group;
            set => IsCorrectString(ref _group, value);
        }

        //Constructors
        public Student()
        {
            UniversityName = "None";
            _course = 1;
            _faculty = "None";
            _group = "None";
        }
        public Student(Entrant entrant)
            : base (entrant)
        {
            UniversityName = "None";
            _course = 1;
            _faculty = "None";
            _group = "None";
        }
        public Student(Entrant entrant, string universityName, double course)
            : this (entrant)
        {
            UniversityName = universityName;
            Course = course;
            _faculty = "None";
            _group = "None";
        }
        public Student(Entrant entrant, string universityName, double course, string faculty)
            :this (entrant, universityName, course)
        {
            Faculty = faculty;
        }
        public Student(Entrant entrant, string universityName, double course, string faculty, string group)
            : this(entrant, universityName, course, faculty)
        {
            Group = group;
        }
        public Student(Student student)
            :base(new Person(student._firstName, student._lastName, student._birthday),
                 student._schoolName, student._pointsBySchool, student._pointsByZNO)
        {
            _universityName = student._universityName;
            _course = student._course;
            _faculty = student._faculty;
            _group = student._group;
        }

        /// <summary>
        /// Methods
        /// </summary>

        //Basic methods
        public override string ToString()
        {
            string entrantString = base.ToString();
            return $"{entrantString}" +
               $"\nInstitute name: {_universityName}" +
               $"\nCoruse: {_course}" +
               $"\nFaculty: {_faculty}" +
               $"\nGroup: {_group}";
        }
    }
}
