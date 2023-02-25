namespace InheritanceLibrary
{
    public class Human // Людина
    {
        // - «Людина» (ім’я, прізвище, дата народження); 
        string Name;
        string Surname;
        string Birthday;

        public Human() // конструктор 
        {
            Name = "Unknown name";
            Surname = "Unknown surname";
            Birthday = "Unknown birthday";
        }

        public Human(string name, string surname) // конструктор з параметрами
        {
            Name = name;
            Surname = surname;
            Birthday = "He|she|It doesn't know his|her birthday.";
        }

        public Human(string name, string surname, string birthday) // конструктор з параметрами
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public Human(Human obj) // конструктор копіювання
        {
            Name = obj.Name;
            Surname = obj.Surname;
            Birthday = obj.Birthday;
        }

        public void SetName(string name) // сет метод
        {
            if(name.Length <= 1) 
            {
                Console.WriteLine("\nSmall am. of symb. of 'name' or was entered incorrectly.");
                Name = "Incorrect name.";
            }
            else
            {
                Name = name;
            }
        }

        public void SetSurname(string surname) // сет метод
        {
            if (surname.Length <= 1)
            {
                Console.WriteLine("\nSmall am. of symb. of 'surname' or was entered incorrectly.");
                Surname = "Incorrect surname.";
            }
            else
            {
                Surname = surname;
            }
        }

        public void SetBirthday(string birthday) // сет метод
        {
            if (birthday.Length < 8)
            {
                Console.WriteLine("Small am. of symb. of 'birthday' or was entered incorrectly.");
                Birthday = "Incorrect birthday.";
            }
            else
            {
                Birthday = birthday;
            }
        }

        public string GetName() { return Name; } // гет метод

        public string GetSurname() { return Surname; } // гет метод

        public string GetBirthday() { return Birthday; } // гет метод

        public virtual void ShowInfo() // віртуальний метод в основному класі
        {
            Console.WriteLine("\nInformation about class 'Human': ");
            Console.WriteLine($"Name: {Name, -10}");
            Console.WriteLine($"Surname: {Surname, -10}");
            Console.WriteLine($"Birthday: {Birthday, -10}");
        }
    }
}
