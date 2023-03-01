using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClass;

List<Person> people = new List<Person>();

people.Add(new Person("Dariia", "Zhurakivska", new DateTime(2002, 07, 21)));
people.Add(new Applicant("Dariia", "Zhurakivska", new DateTime(2002, 07, 21), 190, 200, "Novohrad-Volynskyi school #4"));
people.Add(new Student("Dariia", "Zhurakivska", new DateTime(2002, 07, 21), 1, "RN2", "FJD", "KLV"));
people.Add(new Teacher("Oleh", "Gyryn", new DateTime(1986, 07, 21), "Lector", "KGFD", "KLV"));
people.Add(new LibraryUser("Dariia", "Zhurakivska", new DateTime(2002, 07, 21), 22, new DateTime(2013, 03, 01), 22));

foreach (var person in people)
{
    person.ShowInfo();
    Console.WriteLine("----------------------------------");



    Console.ReadLine(); 
}