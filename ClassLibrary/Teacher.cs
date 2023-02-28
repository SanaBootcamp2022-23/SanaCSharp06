
namespace ClassLibrary
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string UniversityName { get; set; }

        public Teacher() { }

        public Teacher(string firstName, string lastName, DateTime dateOfBirth, string position, string department, string universityName)
            : base(firstName, lastName, dateOfBirth)
        {
            Position = position;
            Department = department;
            UniversityName = universityName;
        }
        public Teacher(Teacher teacher) : base(teacher)
        {
            Position = teacher.Position;
            Department = teacher.Department;
            UniversityName = teacher.UniversityName;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада: {Position}\nКафедра: {Department}\nУніверситет: {UniversityName}");

        }
    }
}

