namespace ClassLibrary
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Chair { get; set; }
        public string UniversityName { get; set; }
        public Teacher(string firstname, string lastname, DateTime birthDate, 
            string position, string chair, string universityName) : 
            base(firstname, lastname, birthDate)
        {
            Position = position;
            Chair = chair;
            UniversityName = universityName;
        }
        public Teacher(string firstname, string lastname, DateTime birthDate, 
            string position, string chair) : 
            base(firstname, lastname, birthDate)
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
