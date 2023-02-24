namespace ClassLibrary
{
    public class Entrant : Person
    {
        public uint ZNOMark { get; set; }
        public uint SchoolMark { get; set; }
        public string SchoolName { get; set; }
        public Entrant(string firstName, string lastName, DateTime birthDate,
            uint znoMark, uint schoolMark, string schoolName) :
            base(firstName, lastName, birthDate)
        {
            ZNOMark = znoMark;
            SchoolMark = schoolMark;
            SchoolName = schoolName;
        }
        public Entrant(string firstName, string lastName, uint znoMark,
            uint schoolMark, string schoolName) : 
            base(lastName, firstName)
        {
            ZNOMark = znoMark;
            SchoolMark = schoolMark;
            SchoolName = schoolName;
        }
        public Entrant() {}

        public override void ShowInfo()
        {
            base.ShowInfo();
            string information = $"Кількість балів сертифікатів ЗНО: {ZNOMark};" +
            $"\nКількість балів за документ про освіту: {SchoolMark};" +
            $"\nНазва загальноосвітнього навчального закладу: {SchoolName}";
            Console.WriteLine(information);
        }
    }
}
