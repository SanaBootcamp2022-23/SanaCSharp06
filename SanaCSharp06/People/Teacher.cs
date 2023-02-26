using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Cathedra { get; set; }
        public string UniversityName { get; set; }
        public Teacher()
        {
            Position = String.Empty;
            Cathedra = String.Empty;
            UniversityName = String.Empty;
        }
        public Teacher(string Name, string SurName, string UniversityName) : base(Name, SurName)
        {
            Position = String.Empty;
            Cathedra = String.Empty;
            this.UniversityName = UniversityName;
        }
        public Teacher(string Name, string SurName, DateTime Birthday, string Position, string Cathedra, string UniversityName) : base(Name, SurName, Birthday)
        {
            this.Position = Position;
            this.Cathedra = Cathedra;
            this.UniversityName = UniversityName;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Position: {Position}\nCathedra: {Cathedra}\nName of University: {UniversityName}");
        }
    }
}
