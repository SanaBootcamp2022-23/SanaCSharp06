namespace ClassLibrary1
{
    public class Student : Human
    {
        public int Course;
        public int Group;
        public string Faculty;
        public string University;
        public Student(string name, string surname, DateTime date, int course, int group, string faculty, string university)
            : base(name, surname, date)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public Student()
            : base()
        {
            Course = 1;
            Group = 1;
            Faculty = "";
            University = "";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Курс: {Course}");
            Console.WriteLine($"Група: {Group}");
            Console.WriteLine($"Факультет: {Faculty}");
            Console.WriteLine($"Університет: {University}");
        }
    }
}
