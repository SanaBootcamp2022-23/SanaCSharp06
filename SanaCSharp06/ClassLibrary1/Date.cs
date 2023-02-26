using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public Date(int year, int month, int day)
        {
            this.Year = year;
            this.Month = month; 
            this.Day = day;
        }
        public Date()
        {
            Year = 0;
            Month = 0;  
            Day = 0;
        }
        public override string ToString() 
        {
            return $"{Day}.{Month}.{Year}";
        }

    }
}
