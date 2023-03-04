using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Enrollee : CertificateZNO
    {
        public uint BalZNO { get; set; }

        public uint Bal { get; set; }

        public Enrollee(string firstName, string lastName, DateTime date, uint english, uint math, uint ukrainianLanguage, uint bal)
            : base(firstName, lastName, date, english, math, ukrainianLanguage)
        {
            BalZNO = Bal();
            Bal = bal;
        }
        public override string ShowInfo()
        {
            return $"Class Enrollee => {FirstName} {LastName} {Date.Year}-{Date.Month}-{Date.Day} English {English} Math {Math} UkrainianLanguage {UkrainianLanguage} BalZNO {BalZNO} Bal {Bal} ";
        }
    }
}
