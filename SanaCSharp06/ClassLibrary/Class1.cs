namespace OOP2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Person(string firstName, string lastName, DateTime birthDate):this(firstName, lastName)
        {
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
            else return $"Ім'я:{LastName} {FirstName} Дата народження:{BirthDate.Day}.{BirthDate.Month}.{BirthDate.Year}";
        }
    }
    public class Abiturient : Person
    {
        public uint ZNOResult
        {
            get
            {
                return ZNOResult;
            }
            set
            {
                if (value <= 200)
                {
                    ZNOResult = value;
                }
            }
        }
        public double SchoolResult
        {
            get
            {
                return SchoolResult;
            }
            set
            {
                if (value > 0 && value <= 12)
                {
                    SchoolResult = value;
                }
            }
        }
        public string SchoolName
        {
            get
            {
                return SchoolName;
            }
            set
            {
                if (value != null)
                {
                    SchoolName = value;
                }
            }
        }
        public Abiturient(string lastName, string firstName, DateTime birthDate, 
            uint znoResult, uint basicEducationResult, string schoolName) :
            base(firstName, lastName, birthDate)
        {
            
        }
        public Abiturient(string lastName, string firstName, uint znoResult,
            double basicEducationResult, string schoolName) : base(lastName, firstName)
        {
            
        }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nРезультат ЗНО: {ZNOResult}, Кількість балів за середню освіту: {SchoolResult}, " +
                $"Назва загальноосвітнього навчального закладу: {SchoolName}";
        }
    }
    public class Student : Person
    {
        public uint YearOfStudy
        {
            get
            {
                return YearOfStudy;
            }
            set
            {
                if (value < 6)
                    YearOfStudy = value;
            }
        }
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
            return $"{base.ShowInfo}\nКурс: {YearOfStudy}, Група: {GroupName}\n" +
                $"Факультет: {Faculty}, Вищий навчальний заклад: {PlaceOfStudy}";
        }
    }
}