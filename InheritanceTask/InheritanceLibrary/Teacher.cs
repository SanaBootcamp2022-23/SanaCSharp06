namespace InheritanceLibrary
{
    sealed public class Teacher : Human // викладач
    {
        // - «Викладач» (посада, кафедра, вищий навчальний заклад);
        string Position;
        string Department;
        string InstitutionOfHigherEducation;

        public Teacher() : base()
        {
            Position = "Unknown position";
            Department = "Unknown department";
            InstitutionOfHigherEducation = "Unknown institution";
        }

        public Teacher(string name, string surname, string position, string department) : base(name, surname) // конструктор з параметрами
        {
            Position = position;
            Department = department;
            InstitutionOfHigherEducation = "He|She|It doesn't know his|her institution.";
        }

        public Teacher(string name, string surname, string birthday, string position, string department, string institution_of_higher_education) : base(name, surname, birthday) // конструктор з параметрами
        {
            Position = position;
            Department = department;
            InstitutionOfHigherEducation = institution_of_higher_education;
        }

        public Teacher(Teacher obj) : base(obj) // конструктор копіювання
        {
            Position = obj.Position;
            Department = obj.Department;
            InstitutionOfHigherEducation = obj.InstitutionOfHigherEducation;
        }

        public void SetPosition(string position) // сет метод
        {
            if (position.Length >=2)
            {
                Position = position;
            }
            else
            {
                Position = "Incorrect position";
                Console.WriteLine($"Small am. of symb. of 'position' or was entered incorrectly.");
            }
        }

        public void SetDepartment(string department) // сет метод
        {
            if (department.Length >= 2)
            {
                Department = department;
            }
            else
            {
                Position = "Incorrect department";
                Console.WriteLine($"Small am. of symb. of 'department' or was entered incorrectly.");
            }
        }

        public void SetInstitutionOfHigherEducation(string institution_of_higher_education) // сет метод
        {
            if (institution_of_higher_education.Length < 10)
            {
                Console.WriteLine("Small am. of symb. of 'institution of higher education' or was entered incorrectly.");
                InstitutionOfHigherEducation = "Incorrect institution of higher education.";
            }
            else
            {
                InstitutionOfHigherEducation = institution_of_higher_education;
            }
        }

        public string GetPosition() { return Position; } // гет метод

        public string GetDepartment() { return Department; } // гет метод

        public string GetInstitutionOfHigherEducation() { return InstitutionOfHigherEducation; } // гет метод

        public override void ShowInfo() // перевизначений метод 
        {
            Console.WriteLine("\nInformation about class 'Teacher': ");
            base.ShowInfo();
            Console.WriteLine($"Position: {Position,-10}");
            Console.WriteLine($"Department: {Department,-10}");
            Console.WriteLine($"Institution of higher education: {InstitutionOfHigherEducation,-10}");
        }
    }
}
