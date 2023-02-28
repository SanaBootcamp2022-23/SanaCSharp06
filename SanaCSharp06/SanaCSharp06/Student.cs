using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06
{
    public class Student : Applicant
    {
        protected int StudyYear;
        protected string GroupName;
        protected string SpecialityName;
        protected string UniversityName;
        public Student(string firstName, string lastName, string birthDate, 
            int examZnoPoints, int averageAtestat,string schoolName,
        int studyYear, string groupName, string specialityName,
        string universityName) : base(firstName, lastName, birthDate, 
            examZnoPoints, averageAtestat, schoolName)
        {
            StudyYear = studyYear;
            GroupName = groupName;
            SpecialityName = specialityName;
            UniversityName = universityName;
        }
    }
}
