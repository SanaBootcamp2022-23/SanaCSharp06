using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06
{


    public class PersonalDateClass
    {
        protected byte day;
        protected ushort year;
        protected byte month;

        public byte Day
        {
            get { return day; }
            set { day = value; }
        }

        public ushort Year
        {
            get { return year; }
            set { year = value; }
        }

        public byte Month
        {
            get { return month; }
            set { month = value; }
        }

        public PersonalDateClass(byte Day, byte Month, ushort Year)
        {
            day = Day;
            year = Year;
            month = Month;
        }

        public string FullDateInfo()
        {

            return ($"{day}/{month}/{year}");
        }
    }

    class People
    {

        protected string firstName;
        protected string lastName;
        protected PersonalDateClass birthdayInfo;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public PersonalDateClass BirthdayInfo
        {
            get { return birthdayInfo; }
            set { birthdayInfo = value; }
        }

        public People(string FirstName, string LastName)
        {
            firstName= FirstName;
            lastName= LastName;
        }
        
        public People(string FirstName, string LastName, PersonalDateClass BirthdayInfo) :this(FirstName, LastName)
        {
            birthdayInfo = BirthdayInfo;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Birthday: {birthdayInfo.FullDateInfo()}");
        }
    }

    class Entrant : People
    {
        protected byte markZNO;
        protected byte markEducation;
        protected string nameOfEducation;

        public byte MarkZNO
        {
            get { return markZNO; }
            set { markZNO = value; }
        }
        public byte MarkEducation
        {
            get { return markEducation; }
            set { markEducation = value; }
        }

        public string NameOfEducation
        {
            get { return nameOfEducation;}
            set { nameOfEducation = value;}
        }

        public Entrant(string FirstName, string LastName, PersonalDateClass BirthdayInfo) : base(FirstName, LastName, BirthdayInfo)
        {

        }

        public Entrant(string FirstName, string LastName, PersonalDateClass BirthdayInfo, byte markZNO, byte markEducation, string nameOfEducation) : base(FirstName, LastName, BirthdayInfo)
        {
            this.markZNO = markZNO;
            this.markEducation = markEducation;
            this.nameOfEducation= nameOfEducation;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Birthday: {birthdayInfo.FullDateInfo()}");
            Console.WriteLine($"ZNO mark: {markZNO}");
            Console.WriteLine($"Average mark of the document on education: {markEducation}");
            Console.WriteLine($"Name of educational institution: {nameOfEducation}");

        }

    }

    class Student : People
    {
        protected string university;
        protected byte course;
        protected string group;
        protected string faculty;

        public string University
        {
            get { return university; }
            set
            {
                university = value;
            }
        }
        public byte Course
        {
            get { return course; }
            set
            {
                course = value;
            }
        }
        public string Group
        {
            get { return group; }
            set
            {
                group = value;
            }
        }
        public string Faculty
        {
            get { return faculty; }
            set
            {
                faculty = value;
            }
        }

        public Student(string FirstName, string LastName, PersonalDateClass BirthdayInfo) : base(FirstName, LastName, BirthdayInfo)
        {

        }

        public Student (string FirstName, string LastName, PersonalDateClass BirthdayInfo, string university, byte course, string group, string faculty):base(FirstName, LastName, BirthdayInfo)
        { 
            this.university = university;
            this.course = course;
            this.group = group;
            this.faculty = faculty;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Birthday: {birthdayInfo.FullDateInfo()}");
            Console.WriteLine($"University: {university}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"Group: {group}");
            Console.WriteLine($"Faculty: {faculty}");
        }


    }

    class Teacher : People
    {
        protected string position;
        protected string department;
        protected string university;

        public string Position
        {
            get { return position; }
            set
            {
                position = value;
            }
        }
        public string Department
        {
            get { return department; }
            set
            {
                department = value;
            }
        }
        public string University
        {
            get { return university; }
            set
            {
                university = value;
            }
        }
        public Teacher(string FirstName, string LastName, PersonalDateClass BirthdayInfo) : base(FirstName, LastName, BirthdayInfo)
        {

        }

        public Teacher(string FirstName, string LastName, PersonalDateClass BirthdayInfo, string Position, string Department, string University) : base(FirstName, LastName, BirthdayInfo)
        {
            position= Position;
            department= Department;
            university= University;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Birthday: {birthdayInfo.FullDateInfo()}");
            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"University: {university}");

        }


    }

    class LibraryUser : People
    {
        protected string idReaderTicket;
        protected PersonalDateClass dataOfIssue;
        protected ushort monthlySizeReadingFee;

        public string IdReaderTicker
        {
            get { return idReaderTicket; }
            set { idReaderTicket = value; }
        }
        public PersonalDateClass DateOfIssue
        {
            get { return dataOfIssue; }
            set { dataOfIssue = value; }
        }
        public ushort MonthlySizeReadingFee
        {
            get { return monthlySizeReadingFee; }
            set { monthlySizeReadingFee = value; }
        }

        public LibraryUser(string FirstName, string LastName, PersonalDateClass BirthdayInfo) : base(FirstName, LastName, BirthdayInfo)
        {

        }

        public LibraryUser(string FirstName, string LastName, PersonalDateClass BirthdayInfo, string idReaderTicket, PersonalDateClass dataOfIssue, ushort monthlySizeReadingFee) : base(FirstName, LastName, BirthdayInfo)
        {
            this.idReaderTicket= idReaderTicket;
            this.dataOfIssue = dataOfIssue;
            this.monthlySizeReadingFee = monthlySizeReadingFee;
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Birthday: {birthdayInfo.FullDateInfo()}");
            Console.WriteLine($"Reader ticket id: {idReaderTicket}");
            Console.WriteLine($"Data of ticket issue: {dataOfIssue.FullDateInfo()}");
            Console.WriteLine($"Size of monthly reader fee: {monthlySizeReadingFee}");
        }
    }


}
