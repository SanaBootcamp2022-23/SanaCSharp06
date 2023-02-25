namespace InheritanceLibrary
{
    sealed public class Student : Human // студент
    {
        // - «Студент» (курс, група, факультет, вищий навчальний заклад);
        int Course;
        string Group;
        string Faculty;
        string InstitutionOfHigherEducation;

        public Student() : base() // конструктор 
        {
            Course = 0;
            Group = "Unknown group";
            Faculty = "Unknown faculty";
            InstitutionOfHigherEducation = "Unknown institution";
        }

        public Student(string name, string surname, int course, string institution_of_higher_education) : base(name, surname) // конструктор з параметрами
        {
            Course = course;
            Group = "He|she|It doesn't know where he|she study.";
            Faculty = "Sorry, what did you ask?";
            InstitutionOfHigherEducation = "He|She|It doesn't know his|her institution.";
        }

        public Student(string name, string surname, string birthday, int course, string group, string faculty, string institution_of_higher_education) : base(name, surname, birthday)// конструктор з параметрами
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            InstitutionOfHigherEducation = institution_of_higher_education;
        }

        public Student(Student obj) : base (obj) // конструктор копіювання
        {
            Course = obj.Course;
            Group = obj.Group;
            Faculty = obj.Faculty;
            InstitutionOfHigherEducation = obj.InstitutionOfHigherEducation;
        }

        public void SetСourse(int course) // сет метод
        {
            if (course >= 1 && course <= 6)
            {
                Course = course;
            }
            else
            {
                Console.WriteLine("Small|big number of 'course' or was entered incorrectly(initialized as 0).");
                Course = 0;
            }
        }

        public void SetGroup(string group) // сет метод
        {
            if (group.Length <= 1)
            {
                Console.WriteLine("Small am. of symb. of 'group' or was entered incorrectly.");
                Group = "Incorrect group.";
            }
            else
            {
                Group = group;
            }
        }

        public void SetFaculty(string faculty) // сет метод
        {
            if (faculty.Length <= 1)
            {
                Console.WriteLine("Small am. of symb. of 'faculty' or was entered incorrectly.");
                Faculty = "Incorrect faculty.";
            }
            else
            {
                Faculty = faculty;
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

        public int GetСourse() { return Course; } // гет метод

        public string GetGroup() { return Group; } // гет метод

        public string GetFaculty() { return Faculty; } // гет метод

        public string GetInstitutionOfHigherEducation() { return InstitutionOfHigherEducation; } // гет метод

        public override void ShowInfo() // перевизначений метод 
        {
            Console.WriteLine("\nInformation about class 'Student': ");
            base.ShowInfo();
            Console.WriteLine($"Course: {Course,-10}");
            Console.WriteLine($"Group: {Group,-10}");
            Console.WriteLine($"Faculty: {Faculty,-10}");
        }
    }
}
