using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CertificateZNO : Person
    {
        
        public uint English { get; set; }
        public uint Math { get; set; }
        public uint UkrainianLanguage { get; set; }

        public CertificateZNO( string firstName, string lastName, DateTime date, uint english, uint math, uint ukrainianLanguage) 
            : base( firstName, lastName, date)
        {
            English = english;
            Math = math;
            UkrainianLanguage = ukrainianLanguage;
        }

        public uint Bal()
        {
            return English + Math + UkrainianLanguage;
        }
        public override string ShowInfo()
        {
            return $"Class CertificateZNO => {FirstName} {LastName} {Date.Year}-{Date.Month}-{Date.Day} English {English} Math {Math} UkrainianLanguage {UkrainianLanguage}";
        }
    }
}
