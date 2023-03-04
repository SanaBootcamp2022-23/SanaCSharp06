using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Enrollee
    {
        public uint Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public Student(string firstName, string lastName, DateTime date, uint english, uint math, uint ukrainianLanguage, uint bal, uint course,string group, string faculty, string university) 
            : base( firstName,  lastName,  date,  english,  math, ukrainianLanguage,  bal)
        {
            BalZNO = Bal();
            Course = course;
            Group = group;  
            Faculty = faculty;  
            University = university;
        }
        public override string ShowInfo()
        {
            return $"Class Student => {FirstName} {LastName} {Date.Year}-{Date.Month}-{Date.Day} English {English} Math {Math} UkrainianLanguage {UkrainianLanguage} BalZNO {BalZNO} Bal {Bal} Course: {Course} Group:{Group} Faculty:{Faculty} University: {University} ";
        }
    }
}
