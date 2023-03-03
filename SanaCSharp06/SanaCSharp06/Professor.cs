using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06
{
    internal class Professor : Person
    {
        protected string post;
        protected string department;
        protected string universityName;
        public string Post
        {
            get { return post; }
            set { if (post != "") post = value; }
        }
        public string Department
        {
            get { return department; }
            set { if (department != "") department = value; }
        }
        public string UniversityName
        {
            get { return universityName; }
            set { if (universityName != "") universityName = value; }
        }
        public Professor(string firstName, string lastName, string birthDate,
            string post, string department,string universityName) : 
            base(firstName, lastName, birthDate)
        {
            Post = post;
            Department = department;
            UniversityName = universityName;
        }
        public Professor(string firstName, string lastName, string birthDate,
            string post) : base(firstName, lastName, birthDate)
        {
            Post = post;
        }
        public override string GetFullInfo()
        {
            return $"\n{FirstName} {LastName} ({BirthDate})" +
                $" in {UniversityName} as {Post} at {Department}";
        }
    }
}
