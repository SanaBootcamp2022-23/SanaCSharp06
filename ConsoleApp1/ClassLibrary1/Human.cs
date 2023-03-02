using System;

namespace ClassLibrary1
{
    public class Human
    {
        private string name;
        private string surname;
        private DateTime dateOfBirth;

        public Human(string name) => SetName(name);
        public Human (string name, string surname, DateTime dateOfBirth)
        {
            SetName(name);
            SetSurname(surname);
            SetDateOfBirth(dateOfBirth);
        }

        public void SetName(string value) => name = value;
        public string GetName() => name;
        public void SetSurname(string value) => surname = value;
        public string GetSurname() => surname;
        public void SetDateOfBirth(DateTime value) => dateOfBirth = value;
        public DateTime GetDateOfBirth() => dateOfBirth;
        public virtual void ShowInfo()
        {
            Console.WriteLine($"\nIм’я: {GetName()}");
            Console.WriteLine($"Прiзвище: {GetSurname()}");
            Console.WriteLine($"Дата народження: {GetDateOfBirth().ToShortDateString()}");
        }
    }
}
