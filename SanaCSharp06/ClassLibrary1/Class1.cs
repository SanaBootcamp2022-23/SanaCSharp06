namespace ClassLibrary1
{
    public class Person
    {
        public string firstName { get; set; }
        protected string fname;
        public string lastName { get; set; }
        protected string lname;
        public Date birthDate { get; set; }
        protected string bdate;
        public Person()
        {
            firstName = "Тарас";
            lastName = "Близнюк";
            birthDate = new Date(12, 10, 2004);
        }
        public Person(string firstName, string lastName, Date birthDate) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
        public virtual string ShowInfo() {
            return $"{firstName} {lastName}, {birthDate.dateToString()}";
        }
    }
    public class Abiturient : Person
    {
        public ExamResults certExamMark { get; set; }
        protected ExamResults cert1;
        public double certSchoolMark {
            get {
                return cert2;
            }
            set {
                if (value > 2)
                    cert2 = value;
            }
        }
        protected double cert2;
        public string edInstName { get; set; }
        protected string educName;
        public Abiturient(string firstName, string lastName, Date birthDate, ExamResults certExamMark, double certSchoolMark, string edInstName) : base(firstName, lastName, birthDate) {
            this.certExamMark = certExamMark;
            this.certSchoolMark = certSchoolMark;
            this.edInstName = edInstName;
        }
        public Abiturient() {
            firstName = "Петро";
            lastName = "Дорошенко";
            birthDate = new Date(15, 10, 2003);
            certExamMark = new ExamResults(190, 193, "англійська мова", 188, "біологія", 190);
            certSchoolMark = 11.8;
            edInstName = "Червоноградський ліцей";
        }
        public override string ShowInfo()
        {
            return $"{firstName} {lastName}, {birthDate.dateToString()}. Загальноосвітний навчальний заклад  - {edInstName}. {certExamMark.resToString()}. Оцінка в шкільному атестаті - {certSchoolMark}";
        }
    }
    public class ExamResults
    {
        public int ukrRes {
            get {
                return ukrainian;
            }
            set {
                if (value >= 100)
                    ukrainian = value;
            }
        }
        protected int ukrainian;
        public int mathRes {
            get {
                return math;
            }
            set { 
                if (value >= 100)
                    math = value;
            }
        }
        protected int math;
        public string thirdExamName { get; set; }
        protected string thirdname;
        public int thirdExamRes {
            get {
                return third;
            }
            set {
                if (value > 100)
                    third = value;
            }
        }
        protected int third;
        public string fourthExamName { get; set; }
        protected string fourthname;
        public int fourthExamRes {
            get {
                return fourth;
            }
            set {
                if (value >= 100)
                    fourth = value;
            }
        }
        protected int fourth;
        public ExamResults(int ukrRes, int mathRes, string thirdExamName, int thirdExamRes, string fourthExamName, int fourthExamRes)
        {
            this.ukrRes = ukrRes;
            this.mathRes = mathRes;
            this.thirdExamName = thirdExamName;
            this.thirdExamRes = thirdExamRes;
            this.fourthExamName = fourthExamName;
            this.fourthExamRes = fourthExamRes;
        }
        public string resToString() {
            return $"Результати ЗНО: українська мова - {ukrRes}, математика - {mathRes}, {thirdExamName} - {thirdExamRes}, {fourthExamName} - {fourthExamRes}";
        }
    }
    public class Date
    {
        public int Day {
            get {
                return day;
            }
            set {
                if (value >= 1 && value <= 31)
                    day = value;
            }
        }
        protected int day;
        public int Month {
            get {
                return month;
            }
            set {
                if (value >= 1 && value <= 12)
                    month = value;
            }
        }
        protected int month;
        public int Year {
            get {
                return year;
            }
            set {
                if (value >= 1970)
                    year = value;
            }
        }
        protected int year;
        public Date(int Day, int Month, int Year){
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }
        public string dateToString(){
            return $"{Day}.{Month}.{Year}";
        }
    }
}