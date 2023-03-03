namespace ClassLibrary
{
    public class Student : Applicant
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }

        public Student(Person person, int course, string group,
            string faculty, string university)
            : base()
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public Student()
                {
                }
        public Student(Applicant applicant, int course,
            string group, string faculty, string university)
            : base(applicant.FirstName,applicant.LastName,
                applicant.DateOfBirth,applicant.ZnoScore, 
                applicant.EducationScore, applicant.School)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Курс: {0}", Course);
            Console.WriteLine("Група: {0}", Group);
            Console.WriteLine("Факультет: {0}", Faculty);
            Console.WriteLine("Вищий навчальний заклад: {0}", University);
        }
    }
}