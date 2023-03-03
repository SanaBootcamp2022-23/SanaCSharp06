using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Applicant : Human
    {
        public int ZnoScore { get; set; }
        public float EducationScore { get; set; }

        public Applicant (int znoScore, float educationScore, string name, string secondName) : base (name, secondName)
        {
            ZnoScore = znoScore;
            EducationScore = educationScore;
        }

        public Applicant (float educationScore, string name, string secondName) : base (name, secondName)
        {
            EducationScore = educationScore;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ZNO Score: {ZnoScore}");
            Console.WriteLine($"Education Score: {EducationScore}");
        }
    }
}
