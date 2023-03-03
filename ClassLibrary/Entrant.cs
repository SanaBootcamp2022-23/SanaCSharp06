using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Entrant : Person
    {
        //Сер Арефметичне
        protected double _average_ZNO;
        protected double _edu_Doc_Res;
        protected string _name_School;

        public double Average_ZNO
        {
            set
            {
                if(value > 100 && value < 200) 
                {
                    _average_ZNO = value;
                }
            }
            get { return _average_ZNO; }
        }
        public double Edu_Doc_Res
        {
            set
            {
                if(value>6 && value < 12)
                {
                    _edu_Doc_Res = value;
                }
            }
            get { return _edu_Doc_Res; }
        }
        public string Name_School
        {
            set
            {
                if (value != "")
                    _name_School = value;
            }
            get { return _name_School; }
        }
        
        public Entrant() { }
        public Entrant(double average_ZNO, double edu_Doc_Res, string name_School)
        {
            Average_ZNO = average_ZNO;
            Edu_Doc_Res = edu_Doc_Res;
            Name_School = name_School;
        }
        public Entrant(string FirstName, string LastName, DateTime dateOfBirth,
            double average_ZNO, double edu_Doc_Res, string name_School) : base(FirstName, LastName, dateOfBirth)
        {
            Average_ZNO = average_ZNO;
            Edu_Doc_Res = edu_Doc_Res;
            Name_School = name_School;
        }
        public Entrant(double average_ZNO, double edu_Doc_Res, string name_School, Person person)
        {
            Average_ZNO = average_ZNO;
            Edu_Doc_Res = edu_Doc_Res;
            Name_School = name_School;
            FirstName = person.FirstName;
            LastName = person.LastName;
            DateBirth = person.DateBirth;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();

            Console.WriteLine($"Avarage_ZNO : {Average_ZNO}");
            Console.WriteLine($"Edu_Document_Result : {Edu_Doc_Res}");
            Console.WriteLine($"Name_School : {Name_School}");
        }
    }
}
