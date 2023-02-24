namespace ClassLibrary
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Chair { get; set; }
        public string UniversityName { get; set; }
        public Teacher(string firstName, string lastName, DateTime birthDate, 
            string position, string chair, string universityName) : 
            base(firstName, lastName, birthDate)
        {
            Position = position;
            Chair = chair;
            UniversityName = universityName;
        }
        public Teacher(string firstName, string lastName, DateTime birthDate, 
            string position, string chair) : 
            base(firstName, lastName, birthDate)
        {
            Position = position;
            Chair = chair;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            string information = $"Посада: {Position};" +
                $"\nКафедра: {Chair};" +
                $"\nВищий навчальний заклад: {UniversityName};";
            Console.WriteLine(information);
        }

    }
}
