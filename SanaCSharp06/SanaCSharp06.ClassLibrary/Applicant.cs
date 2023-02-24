namespace SanaCSharp06.ClassLibrary
{
    public class Applicant : Person
    {
        public decimal EIAMark { get; set; }
        public decimal DocumentOfEducationMark { get; set; }
        public string SchoolName { get; set; } = String.Empty;

        public Applicant(decimal eiaMark, decimal documentOfEducationMark, string schoolName) : this(eiaMark, documentOfEducationMark)
        {
            SchoolName = schoolName;
        }
        
        public Applicant(decimal eiaMark, decimal documentOfEducationMark)
        {
            EIAMark = eiaMark;
            DocumentOfEducationMark = documentOfEducationMark;
        }

        public Applicant() { }

        public override void ShowInfo()
        {
            base.ShowInfo();
            string info = $"Кількість балів сертифікатів ЗНО: {EIAMark};\nКількість балів за документ про освіту: {DocumentOfEducationMark};";
            info += SchoolName == String.Empty ? "" : $"\nНазва загальноосвітнього навчального закладу: {SchoolName}";
            Console.WriteLine(info);
        }
    }
}