using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanaCSharp06
{
    internal class Professor : Person
    {
        protected string Post;
        protected string Department;
        protected string UniversityName;
        public Professor(string firstName, string lastName, string birthDate,
            string post, string department,string universityName) : 
            base(firstName, lastName, birthDate)
        {
            Post = post;
            Department = department;
            UniversityName = universityName;
        }
    }
}
