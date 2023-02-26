namespace ClassLibrary
{
    public class Teacher : People
    {
        protected string WorkPlace;
        protected string Department;
        protected string StudingPlaceName;
        public Teacher(string WorkPlace, string Department, string StudingPlaceName, string Name,
            string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
        {
            this.WorkPlace = WorkPlace;
            this.Department = Department;
            this.StudingPlaceName = StudingPlaceName;
        }
        public Teacher(string WorkPlace, string Department, string Name,
            string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
        {
            this.WorkPlace = WorkPlace;
            this.Department = Department;
            this.StudingPlaceName = "Державний університет";
        }
        public Teacher(string WorkPlace, string Name,
            string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
        {
            this.WorkPlace = WorkPlace;
            this.Department = "ІПЗ";
            this.StudingPlaceName = "Державний університет";
        }
        public Teacher() : base()
        {
            this.WorkPlace = "Викладач";
            this.Department = "ІПЗ";
            this.StudingPlaceName = "Державний університет";
        }
        public string workPlace
        {
            set { if (value.Length > 0) WorkPlace = value; }
            get { return WorkPlace; }
        }
        public string department
        {
            set { if (value.Length > 0) Department = value; }
            get { return Department; }
        }
        public string studingPlaceName
        {
            set { if (value.Length > 0) StudingPlaceName = value; }
            get { return StudingPlaceName; }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада: {WorkPlace}");
            Console.WriteLine($"Кафедра: {Department}");
            Console.WriteLine($"Назва вищого навчального закладу: {StudingPlaceName}");
        }
    }

}
