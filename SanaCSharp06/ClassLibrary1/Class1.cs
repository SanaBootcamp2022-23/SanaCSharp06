namespace ClassLibrary1
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Date birthDate { get; set; }
        public Person(string firstName, string lastName, Date birthDate) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }
        public Person()
        {
            firstName = "Тарас";
            lastName = "Близнюк";
            birthDate = new Date(12, 10, 2004);
        }
        public virtual string ShowInfo() {
            return $"{firstName} {lastName}, {birthDate.dateToString()}";
        }
    }
    public class Abiturient : Person
    {
        public ExamResults certExamMark { get; set; }
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
    public class Student : Person {
        public int studCourse
        {
            get {
                return course;
            }
            set {
                if (value >= 1 && value <= 4)
                    course = value;
            }
        }
        protected int course;
        public string studGroup { get; set; }
        public string studFaculty { get; set; }
        public string uniName { get; set; }
        public Student(string firstName, string lastName, Date birthDate, int studCourse, string studGroup, string studFaculty, string uniName) : base(firstName, lastName, birthDate) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.studCourse = studCourse;
            this.studGroup = studGroup;
            this.studFaculty = studFaculty;
            this.uniName = uniName;
        }
        public Student()
        {
            firstName = "Денис";
            lastName = "Балюк";
            birthDate = new Date(15, 11, 2004);
            studCourse = 2;
            studGroup = "КН-21-1";
            studFaculty = "ФІКТ";
            uniName = "Zhytomyr Polytechinc";
        }
        public override string ShowInfo()
        {
            return $"{firstName} {lastName}, {birthDate.dateToString()}. Вищий навчальний заклад - {uniName}, факультет {studFaculty}, {studCourse}-ий курс, група {studGroup}";
        }
    }
    public class Teacher : Person {
        public string Position { get; set; }
        public string Chair { get; set; }
        public string uniName { get; set; }
        public Teacher(string firstName, string lastName, Date birthDate, string Position, string Chair, string uniName) : base(firstName, lastName, birthDate) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.Position = Position;
            this.Chair = Chair;
            this.uniName = uniName;
        }
        public Teacher() {
            firstName = "Олексій";
            lastName = "Чижмотря";
            birthDate = new Date(21, 07, 1983);
            Position = "викладач практичних занять, голова приймальної комісії";
            Chair = "121 Інженерія програмного забезпечення";
            uniName = "Житомирська політехніка";
        }
        public override string ShowInfo() {
            return $"{firstName} {lastName} {birthDate.dateToString()}. ВНЗ - {uniName}, кафедра - {Chair}, посада - {Position}";
        }
    }
    public class LibraryUser : Person {
        public int ticketNum { get; set; }
        public Date issuanceDay { get; set; }
        public int monthContrib { get; set; }
        public LibraryUser(string firstName, string lastName, Date birthDate, int ticketNum, Date issuanceDay, int monthContrib) : base(firstName, lastName, birthDate) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.ticketNum = ticketNum;
            this.issuanceDay = issuanceDay;
            this.monthContrib = monthContrib;
        }
        public LibraryUser() {
            firstName = "Оксана";
            lastName = "Перебийніс";
            birthDate = new Date(9, 2, 2000);
            ticketNum = 25814;
            issuanceDay = new Date(10, 10, 2019);
            monthContrib = 500;
        }
        public override string ShowInfo() {
            return $"{firstName} {lastName} {birthDate.dateToString()}. Номер читацького квитка - {ticketNum}, дата видачі - {issuanceDay.dateToString()}, щомісячний внесок - {monthContrib} грн.";
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