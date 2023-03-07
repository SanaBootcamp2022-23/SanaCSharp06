using ClassLibrary1;
using System;


class Program
{
   static void Main(string[] args)
   {
        Person person = new Person("Ганчевський","Олександр",new Date(2002,03,11));
        person.ShowInfo();
        Student student = new Student();
        student.ShowInfo();
        Abiturient abiturient = new Abiturient("Олександр","Ганчевський",new Date(2000,05,8),
            200,11,"22");
        abiturient.ShowInfo();  

   }
       
}
    