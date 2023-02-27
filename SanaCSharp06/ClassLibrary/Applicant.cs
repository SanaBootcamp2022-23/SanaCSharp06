using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Applicant : Person
    {
        protected double _ZNOresult { get; set; }
        protected double _certeficateResult { get; set; }
        protected string _schoolName { get; set; }
        public Applicant() { }
        public Applicant(string name, string surname, DateTime dateTime, double znoResult, double certeficateResult, string schoolName) : base(name, surname, dateTime)
        {
            _ZNOresult = znoResult;
            _certeficateResult = certeficateResult;
            _schoolName = schoolName;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ZNO: {_ZNOresult} ");
            Console.WriteLine($"Certeficate Result: {_certeficateResult}");
            Console.WriteLine($"School: {_schoolName}");
        }
    }
}
