namespace ClassLibrary1
{
    public class Entrant : Human
    {
        public int GradeZNO;
        public int GradeCertificate;
        public string School;
        public Entrant(string name, string surname, DateTime date, int gradeZNO, int gradeCertificate, string school)
            : base(name, surname, date)
        {
            GradeZNO = gradeZNO;
            GradeCertificate = gradeCertificate;
            School = school;
        }
        public Entrant()
            : base()
        {
            GradeZNO = 0;
            GradeCertificate = 0;
            School = "";
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Бал ЗНО: {GradeZNO}");
            Console.WriteLine($"Бал атестату: {GradeCertificate}");
            Console.WriteLine($"Школа: {School}");
        }
    }
}
