using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Library
{
    public class Applicant :Human
    {
       private double _avrZNOscore;
       private double _avrSchoolScore;
       private string _schoolName;
        
        public double AvgZNOscore { get { return _avrZNOscore; } set { _avrZNOscore = value; } }
        public double AvgSchoolScore { get { return _avrSchoolScore; } set { _avrSchoolScore= value; } }
        public string SchoolName { get { return _schoolName;} set { _schoolName = value;} }

        public Applicant()
        {
            AvgSchoolScore= 0;
            AvgZNOscore =0;
            SchoolName = "None";
        }
       public Applicant(double avrZNOscore, double avrSchoolScore,string schoolName)
        {
            AvgZNOscore= avrZNOscore;
            AvgSchoolScore= avrSchoolScore;
            SchoolName= schoolName;
        }
        public Applicant (Applicant Copy)
        {
            AvgSchoolScore= Copy.AvgSchoolScore;
            AvgZNOscore= Copy.AvgZNOscore;
            SchoolName= Copy.SchoolName;
        }
        public Applicant(string name,string surname, DateOnly dateOfBirth, double avrZNOscore,
            double avrSchoolScore, string schoolName):base(name, surname,dateOfBirth)
        {
            AvgZNOscore = avrZNOscore;
            AvgSchoolScore = avrSchoolScore;
            SchoolName = schoolName;
        }
        public Applicant (Human human, double avrZNOscore, double avrSchoolScore, string schoolName) : base(human)
        {
            AvgZNOscore = avrZNOscore;
            AvgSchoolScore = avrSchoolScore;
            SchoolName = schoolName;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\n Surname: {Surname}\n Date of birth: {DateOfBirth}\n " +
                $"Average ZNO score: {AvgZNOscore}\n Average School score: {AvgSchoolScore}\n " +
                $"School name: {SchoolName}\n");
        }

    }
}
