using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Prakt
{

    public class Applicant : Human
    {
        protected float totalZNOMark;
        public float TotalZNOMark
        {
            get { return totalZNOMark; }
            set { totalZNOMark = value; }
        }

        protected float educationRecord;
        public float EducationRecord
        {
            get { return educationRecord; }
            set { educationRecord = value; }
        }

        protected string nameOfSchool;
        public string NameOfSchool
        {
            get { return nameOfSchool; }
            set { if (value != null) nameOfSchool = value; }
        }

        public Applicant (string name,string surname, DateTime birthday ,float ZNO, float record, string nameofSchool)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirthday = birthday;
            this.totalZNOMark = ZNO;
            this.educationRecord = record;
            this.nameOfSchool = nameofSchool;
        }
        public Applicant () 
        {
            this.totalZNOMark = 0;
            this.educationRecord = 0;
            this.nameOfSchool = "Undefined";
        }
        public Applicant (Human person, float ZNO, float record, string name) : this(person.Name,person.Surname,person.DateOfBirthday,ZNO,record,name) { }

        public void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Total ZNO mark: {this.totalZNOMark}");
            Console.WriteLine($"Education record mark: {this.educationRecord}");
            Console.WriteLine($"Name of school: {this.nameOfSchool}");
            Console.WriteLine();
        }

    }
}
