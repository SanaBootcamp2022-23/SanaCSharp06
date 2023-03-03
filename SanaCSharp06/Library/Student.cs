using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student : Applicant
    {
      private  int _studyYear;
      private string _group;
      private string _faculty;
      private string _univName;

        public int StudyYear { get { return _studyYear; } set { _studyYear = value; } }
        public string Group { get { return _group;} set { _group = value; } }
        public string Faculty { get { return _faculty;} set { _faculty = value;} }
        public string UnivName { get { return _univName; } set { _univName = value; } }

        public Student(int studyYear, string group, string faculty,string univName) {
            StudyYear= studyYear;
            Group = group;
            Faculty = faculty;
            UnivName = univName;
        }
        public Student (Student Copy)
        {
            StudyYear = Copy.StudyYear;
            Group = Copy.Group;
            Faculty = Copy.Faculty;
            UnivName = Copy.UnivName;
        }
        public Student(int studyYear, string group, string faculty, string univName,
            string name, string surname, DateOnly dateOfBirth,
            double avrZNOscore, double avrSchoolScore, string schoolName):base(name, surname, dateOfBirth, avrZNOscore, avrSchoolScore, schoolName)
        {
            StudyYear = studyYear;
            Group = group;
            Faculty = faculty;
            UnivName = univName;
        }

        public Student(Applicant applicant, int studyYear, string group, string faculty, string univName) : base(applicant)
        {
            StudyYear = studyYear;
            Group = group;    
            Faculty = faculty;
            UnivName = univName;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}\n Study year: {StudyYear}\n" +
                $"Group: {Group}\n Faculty:{Faculty}\n Univercity name:{UnivName}\n Date of birth: {DateOfBirth}\n " +
                $"Average ZNO score: {AvgZNOscore}\n Average School score: {AvgSchoolScore}\n " +
                $"School name: {SchoolName}\n");
        }
    }
}
