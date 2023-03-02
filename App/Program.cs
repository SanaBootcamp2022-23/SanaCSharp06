using ClassLibrary;

 
Person person = new Person("Ivan", "Sirko", new DateTime(2002, 7, 24));
Student student = new Student("Vlad", "Vladovenko", 4, "MO-14", "MOBL", "KLJ");
Abitur abitur = new Abitur("Kon", "Pedalyovij", 183, 11, "Academy UA");
LibraryUser libraryuser = new LibraryUser("Fenya", "Joestar", 724, new DateTime(2021, 9, 17), 329, 2, "ML-7", "MHA", "Academy UA");
Teacher teacher = new Teacher("Roman", "Galon", "director", "JSEY");

person.ShowInfo();
student.ShowInfo();
abitur.ShowInfo();
libraryuser.ShowInfo();
teacher.ShowInfo();