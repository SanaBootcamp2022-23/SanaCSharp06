using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06.Classes
{
    public class Student : Applicant
    {
        public string Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string UniversityName { get; set; }

        public Student(string firstName, string lastName, DateTime birthDate, List<ZNOResult> znoResults,
            float certificateMark, string secondarySchoolName, string course, string group, string faculty,
            string universityName) : base(firstName, lastName, birthDate, znoResults,
            certificateMark, secondarySchoolName)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            UniversityName = universityName;
        }

        public Student(string firstName, string lastName, DateTime birthDate, List<ZNOResult> znoResults,
            float certificateMark, string secondarySchoolName, string course, string faculty,
            string universityName) : base(firstName, lastName, birthDate, znoResults,
            certificateMark, secondarySchoolName)
        {
            Course = course;
            Group = "Unknown";
            Faculty = faculty;
            UniversityName = universityName;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Name: {FirstName},\nLast name: {LastName},\nBirthday: {BirthDate},\n" +
                $"Certificate mark: {CertificateMark},\nSecondary school name: {SecondarySchoolName},\n" +
                $"Course: {Course},\nGroup: {Group},\nFaculty: {Faculty},\nUniversityName: {UniversityName}");

            if (ZNOResults.Count > 0)
            {
                Console.WriteLine("ZNO results:");
                foreach (var result in ZNOResults)
                {
                    Console.WriteLine($"{result.Subject} - {result.Points} points");
                }
            }
            else
            {
                Console.WriteLine("No available ZNO results");
            }
            Console.WriteLine();
        }
    }
}
