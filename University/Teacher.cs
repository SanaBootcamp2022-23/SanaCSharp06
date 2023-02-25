namespace University
{
    public class Teacher : Person
    {
        private string positionName;
        private string departmentName;
        private string universityName;

        public string PositionName
        {
            get { return positionName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    positionName = value;
            }
        }
        public string DepartmentName
        {
            get { return departmentName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    departmentName = value;
            }
        }
        public string UniversityName
        {
            get { return universityName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    universityName = value;
            }
        }

        public Teacher(string name, string surname, DateTime dateOfBirth, string positionName, string departmentName, string universityName) : base(name, surname, dateOfBirth)
        {
            PositionName = positionName;
            DepartmentName = departmentName;
            UniversityName = universityName;
        }
        public Teacher(string name, string surname, string positionName, string departmentName) : this(name, surname, new DateTime(), positionName, departmentName, "")
        { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {PositionName}\nDepartment: {DepartmentName}\n" +
                $"University: {UniversityName}");
        }
    }
}
