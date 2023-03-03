using ClassLibrarySana06;
using System;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Person Holtsev = new Person("Kostia", "Holtsev", 03, 06, 2004);
Person Bubenko = new Person("Alex", "Bubenko", 05,05,1995);

Console.WriteLine(); Console.WriteLine("Person Костянтин Гольцев");
Holtsev.ShowInfo(); Console.WriteLine();


Applicant applicantHoltsev = new Applicant(Holtsev,186, 11.2, "ЖМГ №3");

Console.WriteLine(); Console.WriteLine("Applicant Костянтин Гольцев");
applicantHoltsev.ShowInfo();


Student student_1_ipz24_form = new Student(1, "ІПЗ-22-4", "ФІКТ", "ЖДТУ");

Student student2 = new Student(Holtsev, 1, "ІПЗ-22-4", "ФІКТ", "ЖДТУ");

Student student3 = new Student(applicantHoltsev, 1, "ІПЗ-22-4", "ФІКТ", "ЖДТУ"); 

Student studentHoltsev = student_1_ipz24_form + applicantHoltsev;

Teacher teacherBubenko = new Teacher(Bubenko, "Викладач", "Інформаційні техтології", "ЖДТУ");

LibraryVisitor libVis_Holtsev = new LibraryVisitor(Holtsev,1,12,5,2005,500);

Console.WriteLine(); Console.WriteLine("Форма для додавання студентів (1 курс, іпз-22-4, фікт, ждту)");
student_1_ipz24_form.ShowInfo();

Console.WriteLine(); Console.WriteLine("Student 1. Костянтин Гольцев (конструктор що приймає об'єкт класу Person)");
student2.ShowInfo();

Console.WriteLine(); Console.WriteLine("Student 2. Костянтин Гольцев (конструктор що приймає об'єкт класу Applicant)");
student3.ShowInfo();

Console.WriteLine(); Console.WriteLine("Student 3. Костянтин Гольцев (реалізація перевантаження операції '+', додавання готової форми студента до існуючого об'єкту класу Applicant)");
studentHoltsev.ShowInfo();

Console.WriteLine(); Console.WriteLine("Teacher");
teacherBubenko.ShowInfo();

Console.WriteLine(); Console.WriteLine("Відвідувач бібліотеки - Person");
libVis_Holtsev.ShowInfo();