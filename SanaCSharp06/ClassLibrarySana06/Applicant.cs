using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySana06
{
    public class Applicant:Person
    {
        protected int avg_ZNO_points;
        protected double avg_SchoolSertificate_points;
        protected string schoolname;
        protected Person person;

        public Person Person { get { return person; } private set { person = value; } }
        

        public int Avg_ZNO_Points { get { return avg_ZNO_points; } private set { if (value > 0 && value < 201) avg_ZNO_points = value; } }
        public double Avg_SchoolSertificate_Points { get { return avg_SchoolSertificate_points; } private set { if (value > 0 && value < 13) avg_SchoolSertificate_points = value; } }
        public string Schoolname { get { return schoolname; } private set { if(value != null) schoolname = value; } }

        public Applicant(string firstname, string lastname, int dayofbirth, int mounthofbith, int yearofbirth,
            int avg_ZNO_points, double avg_SchoolSertificate_points, string schoolname) : base(firstname, lastname, dayofbirth, mounthofbith, yearofbirth)
        {
            this.avg_ZNO_points = avg_ZNO_points;
            this.avg_SchoolSertificate_points = avg_SchoolSertificate_points;
            Schoolname = schoolname;
        }

        public Applicant(int avg_ZNO_points, double avg_SchoolSertificate_points, string schoolname)
        {
            this.avg_ZNO_points = avg_ZNO_points;
            this.avg_SchoolSertificate_points = avg_SchoolSertificate_points;
            Schoolname = schoolname;
        }       
        public Applicant(Person person, int avg_ZNO_points, double avg_SchoolSertificate_points, string schoolname)
            : base(person.Firstname,person.Lastname,person.DayOfBirth,person.MontthOfBirth,person.YearOfBirth)
        {
            this.avg_ZNO_points = avg_ZNO_points;
            this.avg_SchoolSertificate_points = avg_SchoolSertificate_points;
            Schoolname = schoolname;
            Person = person;
        }


        public Applicant() { }

        public Applicant(string firstname, string lastname, int dayofbirth, int mounthofbith, int yearofbirth) : base(firstname, lastname, dayofbirth, mounthofbith, yearofbirth)
        {
        }


        public override void ShowInfo()
        {

            if (avg_SchoolSertificate_points == 0) base.ShowInfo();
            else if(avg_SchoolSertificate_points>0 && firstname!="unset")
            {
                base.ShowInfo();
                Console.WriteLine($"(ZNO RESULTS = {avg_ZNO_points}, SCHOOL SERTIFICATE = {avg_SchoolSertificate_points}, SCHOOL NAME = {schoolname}) ");
            }
            else Console.WriteLine($"ZNO RESULTS = {avg_ZNO_points}, SCHOOL SERTIFICATE = {avg_SchoolSertificate_points}, SCHOOL NAME = {schoolname}");
        }
    }
}
