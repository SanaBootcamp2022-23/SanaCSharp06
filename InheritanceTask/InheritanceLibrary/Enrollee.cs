namespace InheritanceLibrary
{
    sealed public class Enrollee : Human // абітурієнт
    {
        // - «Абітурієнт» (кількість балів сертифікатів ЗНО, кількість балів за документ про освіту, назва загальноосвітнього навчального закладу);
        public int[] ResultsEITCertificates;
        double NumberOfPoints;
        string NameOfInstitutionOfHigherEducation;

        public Enrollee() : base()// конструктор 
        {
            NumberOfPoints = 0;
            NameOfInstitutionOfHigherEducation = "Unknown institution";
        }

        public Enrollee(string name, string surname, double number_of_points) : base(name, surname) // конструктор з параметрами
        {
            NumberOfPoints = number_of_points;
            NameOfInstitutionOfHigherEducation = "He|She|It doesn't know his|her institution name.";
        }

        public Enrollee(string name, string surname, string birthday, double number_of_points, string name_of_institution_of_higher_education) : base(name, surname, birthday) // конструктор з параметрами
        {
            NumberOfPoints = number_of_points;
            NameOfInstitutionOfHigherEducation = name_of_institution_of_higher_education;
        }

        public Enrollee(Enrollee obj) : base(obj) // конструктор копіювання
        {
            NumberOfPoints = obj.NumberOfPoints;
            NameOfInstitutionOfHigherEducation = obj.NameOfInstitutionOfHigherEducation;
        }

        public void SetResultsEITCertificates(int[] results_EIT_certificates) // сет метод
        {
            for(int i = 0; i < results_EIT_certificates.Length; i++)
            {
                if(results_EIT_certificates[i] >= 0 && results_EIT_certificates[i] <= 200)
                {
                    ResultsEITCertificates[i] = results_EIT_certificates[i];
                }
                else
                {
                    ResultsEITCertificates[i] = 0;
                    Console.WriteLine($"Small|big number of 'results of EIT certificates' or was entered incorrectly(initialized as 0).");
                }
            }
        }

        public void SetNumberOfPoints(double number_of_points) // сет метод
        {
            if (number_of_points >= 0)
            {
                NumberOfPoints = number_of_points;
            }
            else
            {
                NumberOfPoints = 0;
                Console.WriteLine("Small|big number of 'number of points' or was entered incorrectly(initialized as 0).");
            }
        }

        public void SetNameOfInstitutionOfHigherEducation(string name_of_institution_of_higher_education) // сет метод
        {
            if (name_of_institution_of_higher_education.Length < 10)
            {
                Console.WriteLine("Small am. of symb. of 'name of institution of higher education' or was entered incorrectly.");
                NameOfInstitutionOfHigherEducation = "Incorrect the name of institution of higher education.";
            }
            else
            {
                NameOfInstitutionOfHigherEducation = name_of_institution_of_higher_education;
            }
        }

        public int GetResultsEITCertificates(int i) { return ResultsEITCertificates[i]; } // гет метод

        public double GetNumberOfPoints() { return NumberOfPoints; } // гет метод

        public string GetNameOfInstitutionOfHigherEducation() { return NameOfInstitutionOfHigherEducation; } // гет метод

        public override void ShowInfo() // перевизначений метод 
        {
            Console.WriteLine("\nInformation about class 'Enrollee': ");
            base.ShowInfo();
            Console.WriteLine($"Results of EIT Certificates: ");
            for (int i = 0; i < ResultsEITCertificates.Length; i++)
            {
                Console.Write($"{i} result: {ResultsEITCertificates[i]};\t");
            }
            Console.WriteLine($"\nNumber of points: {NumberOfPoints,-10}");
            Console.WriteLine($"Name of institution of higher education: {NameOfInstitutionOfHigherEducation,-10}");
        }
    }
}
