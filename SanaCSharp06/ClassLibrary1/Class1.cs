using System;
using System.Dynamic;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ClassLibrary1
{

    public class BirthDate
    {
        public int Year = 2023;
        public int Month = 1;
        public int Day = 1;

        public BirthDate(int year, int month, int day)
        {
            if (year <= 2023 && year > 0) { Year = year; }
            if (month > 0 && month <= 12) { Month = month; }
            if (day > 0 && day < 32) { Day = day; }
        }
        public BirthDate()
        {

        }
        public BirthDate(BirthDate date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
        }

        public int GetYear() { return Year; }
        public int GetMonth() { return Month; }
        public int GetDay() { return Day; }

        public void SetYear(int year)
        {
            if (year > 0 && year < 2023) { Year = year; }
        }
        public void SetMonth(int month)
        {
            if (month > 0 && month <= 12) { Month = month; }
        }
        public void SetDay(int day)
        {
            if (day > 0 && day <= 31) { Day = day; }
        }

    }

    public class Person : BirthDate
    {
        protected string Name = "uknown";
        protected string Surname = "uknown";

        public Person(string name, string surname, int year, int month, int day): base(year, month, day)
        {
            Name = name;
            Surname = surname;
        }
        
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Person()
        {

        }
        public string GetName()
        {
            return Name;
        }

        public string GetSurname()
        {
            return Surname;
        }

        public bool SetName(string name)
        {
            if (name.Length > 0)
            {
                Name = name;
                return true;
            }
            else return false;
        }

        public bool SetSurName(string surname)
        {
            if (surname.Length > 0)
            {
                Surname = surname;
                return true;
            }
            else return false;
        }

        public virtual string GetInfo()
        {
            return $"{Name} {Surname} {Year} {Month} {Day}";
        }
    }

    public class Applicant : Person
    {
        protected string Schoolname { set; get; } = "unknown";
        protected int UkrLangRate { set; get; } = 100;
        protected int MathRate { set; get; } = 100;
        protected int HistRate { set; get; } = 100;
        protected int SchoolRate { set; get; } = 11;

        public Applicant(string schoolname, int ukrLangRate, int mathRate, int histRate, int schoolRate, string name, string surname, int year, int month, int day) : base(name, surname, year, month, day)
        {
            if (schoolname.Length > 0)
            {
                Schoolname = schoolname;
            }
            if (ukrLangRate > 100)
            {
                UkrLangRate = ukrLangRate;
            }
            if (mathRate > 100)
            {
                MathRate = mathRate;
            }
            if (histRate > 100)
            {
                HistRate = histRate;
            }
            if (schoolRate > 2)
            {
                SchoolRate = schoolRate;
            }
        }
        public Applicant(string schoolname, int ukrLangRate, int mathRate, int histRate, int schoolRate)
        {
            if (schoolname.Length > 0)
            {
                Schoolname = schoolname;
            }
            if (ukrLangRate > 100)
            {
                UkrLangRate = ukrLangRate;
            }
            if (mathRate > 100)
            {
                MathRate = mathRate;
            }
            if (histRate > 100)
            {
                HistRate = histRate;
            }
            if (schoolRate > 2)
            {
                SchoolRate = schoolRate;
            }

        }
        public Applicant() { }

        public string GetRating()
        {
            return $"UkrLanguage = {UkrLangRate};\nMath = {MathRate}\nHistory = {HistRate}\nSchool rate = {SchoolRate}";
        }
        public string GetSchool()
        {
            return Schoolname;
        }

        public bool SetRating(int ukrLangRate, int mathRate, int histRate, int schoolRate)
        {
            if (ukrLangRate > 100)
            {
                UkrLangRate = ukrLangRate;
            }
            if (mathRate > 100)
            {
                MathRate = mathRate;
            }
            if (histRate > 100)
            {
                HistRate = histRate;
            }
            if (schoolRate > 2)
            {
                SchoolRate = schoolRate;
            }
            return true;
        }
        public bool SetSchool(string schoolname)
        {
            if (schoolname.Length > 0)
            {
                Schoolname = schoolname;
            }
            return true;
        }
        public override string GetInfo()
        {
            return $"\nApplicant: School name:{Schoolname} - UkrRate: {UkrLangRate} - MathRate:{MathRate} - Hist rate:{HistRate} - SR: {SchoolRate} - Name:{Name} - Surname: {Surname} - Year:{Year} - Month:{Month} - Day:{Day}";
        }
    }

    public class Student: Applicant
    {
        protected int Course { set; get; } = 1;
        protected int Group { set; get; } = 1;
        protected int Facultative { set; get; } = 111;
        protected string HighEdPlace { set; get; } = "unknown";

        public Student(int course, int group, int fac, string hep, string schoolname, int ukrLangRate, int mathRate, int histRate, int schoolRate, string name, string surname, int year, int month, int day): base(schoolname, ukrLangRate, mathRate, histRate, schoolRate, name, surname, year, month, day)
        {
            if (course > 0) Course= course;
            if(group>0) Group= group;
            if(fac>0) Facultative= fac;
            if(hep.Length>0) HighEdPlace= hep;
        }

        public Student(int course, int group, int fac, string hep)
        {
            if (course > 0) Course = course;
            if (group > 0) Group = group;
            if (fac > 0) Facultative = fac;
            if (hep.Length > 0) HighEdPlace = hep;
        }

        public Student() { }

        public string GetStudLoc()
        {
            return $"\nCourse {Course}\nGroup {Group}\nFacultative {Facultative}";
        }

        public string GetHEP()
        {
            return $"High educational place - {HighEdPlace}";
        }

        public bool SetStudLoc(int course, int group, int fac)
        {
            if (course > 0) Course= course;
            if(group>0) Group= group;
            if(fac>0) Facultative= fac;
            return true;
        }
    
        public bool SetHEP(string hep)
        {
            if (hep.Length > 0) HighEdPlace = hep;
            return true;
        }

        public override string GetInfo()
        {
            return $"\nStudent:\nCourse - {Course}\nGroup - {Group}\nFacultative-{Facultative}\nHigh educational place - {HighEdPlace}\nSchool name - {Schoolname}\nUkr Language rate-{UkrLangRate}\nMath rate-{MathRate}\nHistory rate-{HistRate}\nSchool rate-{SchoolRate}\nName-{Name}\nSurname-{Surname}\nBirth year-{Year}\nBirth month-{Month}\nBirth day-{Day}";
        }
    }
    public class Teacher: Person
    {
        protected string Position { set; get; }
        protected string Chair { set; get; }
        protected string HighEdPlace { set; get; }

        public Teacher(string position, string chair, string highEdPlace, string name, string surname, int year, int month, int day) : base(name, surname, year, month, day)
        {
            SetTeacher(position, chair, highEdPlace);
        }
        public Teacher(string position, string chair, string highEdPlace)
        {
            SetTeacher(position, chair, highEdPlace);
        }
        public string GetTeacher()
        {
            return $"Position - {Position}\n Chair - {Chair}\n High educational place - {HighEdPlace}";
        }
        public bool SetTeacher(string pos, string chair, string hep)
        {
            if (pos.Length > 0)
            {
                Position = pos;
            }
            if (chair.Length > 0)
            {
                Chair = chair;
            }
            if (hep.Length > 0)
            {
                HighEdPlace = hep;
            }
            return true;
        }

        public override string GetInfo()
        {
            return $"\nTeacher:\nPosition - {Position}\nChair - {Chair}\nHight educational place - {HighEdPlace}\nName-{Name}\nSurname-{Surname}\nBirth year-{Year}\nBirth month-{Month}\nBirth day-{Day}";
        }
    }
    public class LibraryVisitor:Person
    {
        protected int ID { set; get; } = 1111;
        protected int IssueYear { set; get; } = 2023;
        protected int IssueMonth { set; get; } = 1;
        protected int IssueDay { set; get; } = 1;
        protected int ReaderFee { set; get; }

        public LibraryVisitor(int id, int isyear, int ismonth, int isDay, int readerfee, string name, string surname, int year, int month, int day) : base(name, surname, year, month, day)
        {
            SetLV(id, isyear, ismonth, isDay, readerfee);
        }
        public LibraryVisitor(int id, int isyear, int ismonth, int isDay, int readerfee)
        {
            SetLV(id, isyear, ismonth, isDay, readerfee);
        }
        public string GetLV()
        {
            return $"ID - {ID}\n Issue year - {IssueYear}\n Issue month - {IssueMonth}\n Issue day - {IssueDay}\n Reader fee {ReaderFee}";
        }
        public bool SetLV(int id, int isyear, int ismonth, int isDay, int readerfee)
        {
            if (id > 1000)
            {
                ID = id;
            }
            if (isyear > 1980)
            {
                IssueYear=isyear;
            }
            if (ismonth > 0 && ismonth <=12)
            {
                IssueMonth=ismonth;
            }
            if (isDay > 0 && isDay<=30)
            {
                IssueDay=isDay;
            }
            if (readerfee > 0)
            {
                ReaderFee = readerfee;
            }
            return true;
        }

        public override string GetInfo()
        {
            return $"\nLibrary visitor:\nID - {ID}\nIssue year - {IssueYear}\nIssue month - {IssueMonth}\nIssue day - {IssueDay}\nReader fee - {ReaderFee}\nName-{Name}\nSurname-{Surname}\nBirth year-{Year}\nBirth month-{Month}\nBirth day-{Day}";
        }
    }

}