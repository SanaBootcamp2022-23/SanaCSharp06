using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Abiturient : Human
    {
        private int znoPoints;
        private double dokumentOsvita;
        private string nameOfSchool;

        public int ZnoPoints { get => znoPoints; set => znoPoints = value; }
        public double DokumentOsvita { get => dokumentOsvita; set => dokumentOsvita = value; }
        public string NameOfSchool { get => nameOfSchool; set => nameOfSchool = value; }

        public Abiturient()
        {

        }

        public Abiturient(string name, string surName, DateTime dateOfBirth, int znoPoints, double dokumentOsvita, string nameOfSchool) : base(name, surName, dateOfBirth)
        {
            ZnoPoints = znoPoints;
            DokumentOsvita = dokumentOsvita;
            NameOfSchool = nameOfSchool;
        }

        public Abiturient(Abiturient copyAbiturient)
        {
            Name = copyAbiturient.Name;
            SurName = copyAbiturient.SurName;
            DateOfBirth = copyAbiturient.DateOfBirth;
            ZnoPoints = copyAbiturient.ZnoPoints;
            dokumentOsvita = copyAbiturient.ZnoPoints;
            NameOfSchool = copyAbiturient.NameOfSchool;

        }

        public override void ShowInfo()
        {
            //Console.WriteLine($"name: {Name}\t surName: {SurName}\t dateofBirth: {DateOfBirth}\t znoPoints: {znoPoints}\t dokumentOsvita: {dokumentOsvita}\t nameOfUniversity: {nameOfUniversity}\t");
            base.ShowInfo();
            Console.WriteLine($"Інформація про абітурієнта: \nКількість балів сертифікатів ЗНО: {ZnoPoints}\t Кількість балів за документ про освіту: {DokumentOsvita}\t Назва загальноосвітнього навчального закладу: {NameOfSchool}");
        }
    }

}
