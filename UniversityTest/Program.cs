using UniversityLibrary;

Applicant applicant = new Applicant("Влад", "Тетерівський", new DateTime(2002, 5, 19),
    180, 10.2, "Коростишівська ЗОШ №1");
applicant.ShowInfo();

Student student = new Student("Андрій", "Макаревич", new DateTime(2002, 2, 7), 4,
    "ТА-92", "Автоматизація енергетичних процесів", "НТУУ \"Київський політехнічний інститут імені Ігоря Сікорського\"");
student.ShowInfo();

Teacher teacher = new Teacher("Олександр", "Степанець",new DateTime(1980, 5, 2), "Професор", 
    "Компʼютерні науки", "НТУУ \"Київський політехнічний інститут імені Ігоря Сікорського\"");
teacher.ShowInfo();

LibraryUser libraryUser = new LibraryUser("Анатолій", "Хмільно-Вишневий", new DateTime(1995, 1, 1),
    12345, 10.99m,new DateTime(2022, 1, 1));
libraryUser.ShowInfo();

Console.ReadLine();