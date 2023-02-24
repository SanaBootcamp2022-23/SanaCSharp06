namespace SanaCSharp06.ClassLibrary
{
    public class Applicant : Person
    {
        public decimal EIAMark { get; set; }
        public decimal DocumentOfEducationMark { get; set; }
        public string SchoolName { get; set; } = String.Empty;

        public Applicant(string name, string surname, DateTime dateOfBirth, decimal eiaMark, decimal documentOfEducationMark, string schoolName) : base(name, surname, dateOfBirth)
        {
            EIAMark = eiaMark;
            DocumentOfEducationMark = documentOfEducationMark;
            SchoolName = schoolName;
        }
        
        public Applicant(string name, string surname, DateTime dateOfBirth, decimal eiaMark, decimal documentOfEducationMark) : base(name, surname, dateOfBirth)
        {
            EIAMark = eiaMark;
            DocumentOfEducationMark = documentOfEducationMark;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Кількість балів сертифікатів ЗНО: {EIAMark};\nКількість балів за документ про освіту: {DocumentOfEducationMark};";
            info += SchoolName == String.Empty ? "" : $"\nНазва загальноосвітнього навчального закладу: {SchoolName}";
            Console.WriteLine(info);
        }
    }
}