namespace University
{
    public class Teacher : Person
    {
        public string PositionName
        {
            get { return PositionName; }
            set
            {
                if (!string.IsNullOrEmpty(PositionName))
                    PositionName = value;
            }
        }
        public string DepartmentName
        {
            get { return DepartmentName; }
            set
            {
                if (!string.IsNullOrEmpty(DepartmentName))
                    DepartmentName = value;
            }
        }
        public string UniversityName
        {
            get { return UniversityName; }
            set
            {
                if (!string.IsNullOrEmpty(UniversityName))
                    UniversityName = value;
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
