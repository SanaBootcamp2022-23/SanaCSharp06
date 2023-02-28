using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Human
    {
        private string posada;
        private string kafedra;
        private string vnz;

        public string Posada { get => posada; set => posada = value; }
        public string Kafedra { get => kafedra; set => kafedra = value; }
        public string Vnz { get => vnz; set => vnz = value; }

        public Teacher()
        { }


        public Teacher(string name, string surName, DateTime dateOfBirth, string posada, string kafedra, string vnz) : base(name, surName, dateOfBirth)
        {
            Posada = posada;
            Kafedra = kafedra;
            Vnz = vnz;
        }

        public Teacher(Teacher copyTeacher)
        {
            Name = copyTeacher.Name;
            SurName = copyTeacher.SurName;
            DateOfBirth = copyTeacher.DateOfBirth;
            Posada = copyTeacher.Posada;
            Kafedra = copyTeacher.Kafedra;
            Vnz = copyTeacher.Vnz;

        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Інформація про викладача:\nПосада:{Posada}\t Кафедра:{Kafedra}\t Назва вищого навчального закладу:{Vnz}");
        }

    }
}
