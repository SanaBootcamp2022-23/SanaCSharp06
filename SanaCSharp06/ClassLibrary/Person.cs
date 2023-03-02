using System.Data;

namespace ClassLibrary
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string DateOfBirth { get; set; }

        private void OutPut()
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.InputEncoding = System.Text.Encoding.Default;

        }
        public Person(string name,string surName, string dateOfBirth)
        {
            Name = name;
            SurName = surName;
            DateOfBirth = dateOfBirth;
        }
        public Person(Person person) 
        {
            Name = person.Name;
            SurName = person.SurName;
            DateOfBirth = person.DateOfBirth;
        }
        public virtual void ShowInfo()
        {
            OutPut();
            Console.WriteLine("Мене звати {0} {1},я народився {2}", Name, SurName, DateOfBirth);
        }
    }
}