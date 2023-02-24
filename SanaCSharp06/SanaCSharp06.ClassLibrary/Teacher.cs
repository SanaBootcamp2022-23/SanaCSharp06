namespace SanaCSharp06.ClassLibrary
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Chair { get; set; }
        public string UniversityName { get; set; } = String.Empty;
        public Teacher(string name, string surname, DateTime dateOfBirth, string position, string chair, string universityName) : base(name, surname, dateOfBirth)
        {
            Position = position;
            Chair = chair;
            UniversityName = universityName;
        }

        public Teacher(string name, string surname, DateTime dateOfBirth, string position, string chair) : base(name, surname, dateOfBirth)
        {
            Position = position;
            Chair = chair;
        }
        
        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Посада: {Position};\nКафедра: {Chair};";
            info += UniversityName == String.Empty ? "" : $"\nНазва вищого навчального закладу: {UniversityName}";
            Console.WriteLine(info);
        }

    }
}