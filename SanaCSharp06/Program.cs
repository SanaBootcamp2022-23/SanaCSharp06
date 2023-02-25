using SanaCSharp6;
using System;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;
List<Person> person = new List<Person>();

person.Add(new Person("Дмитро", "Іванов"));
person.Add(new Person("Іван", "Дмитренко", "01.01.1984"));


person.Add(new Applicant("Дмитро", "Іванов", "10.10.1984", "140", "21", "ЗОШ №6"));


person.Add(new Student("Назар", "Зелен", "20.12.1984", "2", "18 -8", "21", "ЖТДУ №4"));


person.Add(new Teacher("Микола", "Червоний", "23.10.1984", "викладач", "КН", "ЖТДУ №4"));

person.Add(new UserOfLibrary("Барт", "Жовтий", "5.07.1984", "23", "10.10.2022", "111,90"));

//Викликаємо реалізовані методи для кожного об'єкту
foreach (var pers in person)
{
    pers.ShowInfo();
    Console.WriteLine(new string('-', 20));
}