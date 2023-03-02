namespace ClassLibrary1
{
    public class Teacher : Human
    {
        public string Position;
        public string Cathedra;
        public string University;
        public Teacher(string name, string surname, DateTime date, string position, string cathedra, string university)
            : base(name, surname, date)
        {
            Position= position;
            Cathedra= cathedra;
            University = university;
        }
        public Teacher()
            : base()
        {
            Position = "";
            Cathedra = "";
            University = "";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Посада: {Position}");
            Console.WriteLine($"Кафедра: {Cathedra}");
            Console.WriteLine($"Університет: {University}");
        }
    }
}
