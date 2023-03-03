using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06
{
    public class Student : Applicant
    {
        protected int studyYear;
        protected string groupName;
        protected string specialityName;
        protected string universityName;
        public int StudyYear
        {
            get { return studyYear; }
            set { if (studyYear >= 1 && studyYear < 8) studyYear = value; }
        }
        public string GroupName
        {
            get { return groupName; }
            set { if(groupName != "") groupName = value; }
        }
        public string SpecialityName
        {
            get { return specialityName; }
            set { if (specialityName != "") specialityName = value; }
        }
        public string UniversityName
        {
            get { return universityName; }
            set { if(universityName != "") universityName = value;}
        }
        public Student(string firstName, string lastName, string birthDate, 
            int examZnoPoints, double averageAtestat,string schoolName,
        int studyYear, string groupName, string specialityName,
        string universityName) : base(firstName, lastName, birthDate, 
            examZnoPoints, averageAtestat, schoolName)
        {
            StudyYear = studyYear;
            GroupName = groupName;
            SpecialityName = specialityName;
            UniversityName = universityName;
        }
        public Student(string firstName, string lastName, string birthDate,
            int examZnoPoints, double averageAtestat, string schoolName,
        int studyYear, string groupName, string universityName) :
            base(firstName, lastName, birthDate,
            examZnoPoints, averageAtestat, schoolName)
        {
            StudyYear = studyYear;
            GroupName = groupName;
            UniversityName = universityName;
        }
        public override string GetFullInfo()
        {
            return $"\n{FirstName} {LastName} ({BirthDate}) Atestat: {AverageAtestat}, " +
                $"ZNO: {ExamZnoPoints} in {SchoolName}\n" +
                $"Now in {UniversityName} [{GroupName}] as {SpecialityName} on {StudyYear}";
        }
    }
}
