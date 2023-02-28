using Microsoft.VisualBasic;

namespace ClassLibrary
{
    public class Human
    {
        private string name;
        private string surName;
        private DateTime dateOfBirth;

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }

        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public Human()
        {

        }

        public Human(string name, string surName, DateTime dateOfBirth)
        {
            Name = name;
            SurName = surName;
            DateOfBirth = dateOfBirth;
        }

        public Human(Human copyHuman)
        {
            Name = copyHuman.Name;
            SurName = copyHuman.SurName;
            DateOfBirth = copyHuman.DateOfBirth;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Інформація про людину: \nІм'я: {Name}\t Прізвище: {SurName}\t Дата народження: {DateOfBirth.ToString("dd/MM/yyyy")}");
        }
    }
}