namespace ClassLibrary
{
    public class Entrant : Person
    {
        public double NumberOfPointsOfEIT { get; set; }
        public double NumberOfPointsOfEducational { get; set; }
        public string SchoolName { get; set; }

        public Entrant() { }
        public Entrant(string firstName, string lastName, DateTime dateOfBirth, double numberOfPointsOfEIT, double numberOfPointsOfEducational, string schoolName)
            : base(firstName, lastName, dateOfBirth)
        {
            NumberOfPointsOfEIT = numberOfPointsOfEIT;
            NumberOfPointsOfEducational = numberOfPointsOfEducational;
            SchoolName = schoolName;
        }
        public Entrant(Entrant entrant) : base(entrant)
        {
            NumberOfPointsOfEIT = entrant.NumberOfPointsOfEIT;
            NumberOfPointsOfEducational = entrant.NumberOfPointsOfEducational;
            SchoolName = entrant.SchoolName;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Кількість балів сертифікату ЗНО: {NumberOfPointsOfEIT}\nКількість балів за документ про освіту: {NumberOfPointsOfEducational}\nЗагальноосвітній навчальний заклад: {SchoolName}");
        }
    }
}
