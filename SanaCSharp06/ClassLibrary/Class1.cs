namespace OOP2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
        public virtual string ShowInfo()
        {
            if (BirthDate.Year == 1)
                return $"Ім'я:{LastName} {FirstName}";
            else return $"Ім'я:{LastName} {FirstName} Дата народження:" +
                    $"{BirthDate.Day}.{BirthDate.Month}.{BirthDate.Year}\n";
        }
    }
    public class Abiturient : Person
    {
        public int ZNOResult { get; set; }

        public uint SchoolResult { get; set; }
        public string SchoolName
        { get; set; }
        public Abiturient(string lastName, string firstName, DateTime birthDate,
            int znoResult, uint basicEducationResult, string schoolName) :
            base(firstName, lastName, birthDate)
        {
            ZNOResult = znoResult;
            SchoolResult = basicEducationResult;
            SchoolName = schoolName;
        }
        public Abiturient(string lastName, string firstName, int znoResult,
            uint basicEducationResult, string schoolName) : base(lastName, firstName)
        {
            ZNOResult = znoResult;
            SchoolResult = basicEducationResult;
            SchoolName = schoolName;
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nРезультат ЗНО: {ZNOResult}, Кількість балів за середню освіту: " +
                $"{SchoolResult},\n" +
                $"Назва загальноосвітнього навчального закладу: {SchoolName}\n";
        }
    }
    public class Student : Person
    {
        public uint YearOfStudy
        { get; set; }
        public string GroupName { get; set; }
        public string Faculty { get; set; }
        public string PlaceOfStudy { get; set; }
        public Student(string lastName, string firstName, DateTime birthDate, uint yearOfStudy,
            string groupName, string faculty, string placeOfStudy) : base(lastName, firstName, birthDate)
        {
            YearOfStudy = yearOfStudy;
            GroupName = groupName;
            Faculty = faculty;
            PlaceOfStudy = placeOfStudy;
        }
        public Student(string lastName, string firstName, uint yearOfStudy,
          string groupName, string faculty, string placeOfStudy) : base(lastName, firstName)
        {
            YearOfStudy = yearOfStudy;
            GroupName = groupName;
            Faculty = faculty;
            PlaceOfStudy = placeOfStudy;
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nКурс: {YearOfStudy}, Група: {GroupName}\n" +
                $"Факультет: {Faculty}, Вищий навчальний заклад: {PlaceOfStudy}\n";
        }
    }
    public class Teacher : Person
    {
        public string JobPosition { get; set; }
        public string Chair { get; set; }
        public string PlaceOfWork { get; set; }
        public Teacher(string lastName, string firstName, DateTime birthDate, string jobPosition,
            string chair, string placeOfWork) : base(lastName, firstName, birthDate)
        {
            JobPosition = jobPosition;
            Chair = chair;
            PlaceOfWork = placeOfWork;
        }
        public Teacher(string lastName, string firstName, string jobPosition,
            string chair, string placeOfWork) : base(lastName, firstName)
        {
            JobPosition = jobPosition;
            Chair = chair;
            PlaceOfWork = placeOfWork;
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nПосада: {JobPosition}, Кафедра: {Chair}, " +
                $"Вищий навчальний заклад:{PlaceOfWork}\n";
        }
    }
    public class LibraryEnjoyer : Person
    {
        public uint ReaderID { get; set; }
        public DateTime RecieveDate { get; set; }
        public double MonthlyFee { get; set; }
        public LibraryEnjoyer(string lastName, string firstName, DateTime birthDate,
            uint readerID, DateTime recieveDate, double monthlyFee) : base(lastName, firstName, birthDate)
        {
            ReaderID = readerID;
            MonthlyFee = monthlyFee;
            RecieveDate = recieveDate;
        }
        public LibraryEnjoyer(string lastName, string firstName,
            uint readerID, DateTime recieveDate, double monthlyFee) : base(lastName, firstName)
        {
            ReaderID = readerID;
            MonthlyFee = monthlyFee;
            RecieveDate = recieveDate;
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nНомер читацького квитка: {ReaderID}, Дата видачі:" +
                $" {RecieveDate.Day}.{RecieveDate.Month}.{RecieveDate.Year}," +
                $" Щомісячний внесок: {MonthlyFee}\n";
        }
    }
}