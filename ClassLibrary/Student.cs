using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Student : Abiturient
    {
        private int kurs;
        private string group;
        private string fakultet;
        private string vnz;

        public int Kurs { get => kurs; set => kurs = value; }
        public string Group { get => group; set => group = value; }
        public string Fakultet { get => fakultet; set => fakultet = value; }
        public string VNZ { get => vnz; set => vnz = value; }

        public Student()
        { }

        public Student(string name, string surName, DateTime dateOfBirth, int kurs, string group, string fakultet, string vnz, int znoPoints, double dokumentOsvita, string nameOfSchool) : base(name, surName, dateOfBirth, znoPoints, dokumentOsvita, nameOfSchool)
        {
            Kurs = kurs;
            Group = group;
            Fakultet = fakultet;
            VNZ = vnz;
        }

        public Student(Student copyStudent)
        {
            Kurs = copyStudent.Kurs;
            Group = copyStudent.Group;
            Fakultet = copyStudent.Fakultet;
            VNZ = copyStudent.VNZ;
            Name = copyStudent.Name;
            SurName = copyStudent.SurName;
            DateOfBirth = copyStudent.DateOfBirth;
            NameOfSchool = copyStudent.NameOfSchool;
            ZnoPoints = copyStudent.ZnoPoints;
            DokumentOsvita = copyStudent.DokumentOsvita;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Інформація про студента:\nКурс:{Kurs}\t Група:{Group}\t Факультет:{Fakultet}");
        }
    }
}
