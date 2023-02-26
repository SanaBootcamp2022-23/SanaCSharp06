namespace ClassLibrary
{
    public class Entrant : People
    {
        protected int ZnoMark;
        protected int SchoolMark;
        protected string SchoolName;
        public Entrant(int ZnoMark, int SchoolMark, string SchoolName, string Name,
            string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
        {
            this.ZnoMark = ZnoMark;
            this.SchoolMark = SchoolMark;
            this.SchoolName = SchoolName;
        }
        public Entrant(int ZnoMark, int SchoolMark, string Name,
            string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
        {
            this.ZnoMark = ZnoMark;
            this.SchoolMark = SchoolMark;
            this.SchoolName = "ЗОШ";
        }
        public Entrant(int ZnoMark, string Name,
            string Surname, string BirthdayDate) : base(Name, Surname, BirthdayDate)
        {
            this.ZnoMark = ZnoMark;
            this.SchoolMark = 150;
            this.SchoolName = "ЗОШ";
        }
        public Entrant() : base()
        {
            this.ZnoMark = 150;
            this.SchoolMark = 150;
            this.SchoolName = "ЗОШ";
        }
        public int znoMark
        {
            set { if (value > 0 && value <= 200) ZnoMark = value; }
            get { return ZnoMark; }
        }
        public int schoolMark
        {
            set { if (value > 0 && value <= 200) SchoolMark = value; }
            get { return SchoolMark; }
        }
        public string schoolName
        {
            set { if (value.Length > 0) SchoolName = value; }
            get { return SchoolName; }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"І'мя: {Name}");
            Console.WriteLine($"Прізвище: {Surname}");
            Console.WriteLine($"Дата народження: {BirthdayDate}");
            Console.WriteLine($"Оцінка ЗНО: {ZnoMark}");
            Console.WriteLine($"Оцінка за атестат: {SchoolMark}");
            Console.WriteLine($"Назва школи: {SchoolName}");
        }
    }

}
