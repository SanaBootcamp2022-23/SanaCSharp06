using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Abiturient : People
    {
        public Dictionary<string,int> ZNOMarks { set; get; }
        public float DocMark { set; get; }
        public string Zaklad { set; get; }

        public Abiturient(string zaklad,Dictionary<string,int> dict,float docmark,string name, string lastname, string date) : base(name, lastname, date)
        {
            this.Zaklad = zaklad;
            this.DocMark = docmark;
            this.ZNOMarks = dict;
        }

        public Abiturient()
        { }

        protected string ShowMarks()
        {
            string str = "";
            foreach(var mark in ZNOMarks)
            {
                str += $"{mark.Key} - {mark.Value}\n";
            }
            return str;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Abiturient Info:\n" +
                $"Name: {this.FirstName}\n" +
                $"SurName: {this.LastName}\n" +
                $"Date: {this.Date}\n" +
                $"ZNO Marks:\n{this.ShowMarks()}\n" +
                $"Graduation mark: {this.DocMark}\n" +
                $"Zaklad: {this.Zaklad}\n");

        }
    }
}
