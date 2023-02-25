using System.Text;
using InheritanceLibrary;

namespace Inheritance
{
    internal class Inheritance
    {
        static public void CreateHuman(ref Human FirstConstructorHuman, ref Human SecondtConstructorHuman, ref Human ThirdConstructorHuman, int ChooseInput)
        {
            switch (ChooseInput)
            {
                // конструктор по замовчуванню
                case 1:
                    {
                        FirstConstructorHuman = new Human();

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                // конструктор з параметрами (1)
                case 2:
                    {
                        string name, surname;
                        Console.Write("Введіть ім'я людини: "); name = Console.ReadLine();
                        Console.Write("Введіть прізвище людини: "); surname = Console.ReadLine();

                        SecondtConstructorHuman = new Human(name, surname);
                        // Set методи
                        SecondtConstructorHuman.SetName(name); SecondtConstructorHuman.SetSurname(surname);

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                // конструктор з параметрами (2)
                case 3:
                    {
                        string name, surname, birthday;
                        Console.Write("Введіть ім'я людини: "); name = Console.ReadLine();
                        Console.Write("Введіть прізвище людини: "); surname = Console.ReadLine();
                        Console.Write("Введіть день народження людини: "); birthday = Console.ReadLine();

                        ThirdConstructorHuman = new Human(name, surname, birthday);
                        // Set методи
                        ThirdConstructorHuman.SetName(name); ThirdConstructorHuman.SetSurname(surname); ThirdConstructorHuman.SetBirthday(birthday);

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
            }
        }

        static public void CreateStudent(ref Student FirstConstructorStudent, ref Student SecondtConstructorStudent, ref Student ThirdConstructorStudent, int ChooseInput)
        {
            switch (ChooseInput)
            {
                // конструктор по замовчуванню
                case 1:
                    {
                        FirstConstructorStudent = new Student();

                        Console.WriteLine("Об'єкт створено!");
                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                // конструктор з параметрами (1)
                case 2:
                    {
                        int course; string institution_of_higher_education;
                        string name, surname;
                        Console.Write("Введіть ім'я студента: "); name = Console.ReadLine();
                        Console.Write("Введіть прізвище студента: "); surname = Console.ReadLine();
                        Console.Write("Введіть номер курсу студента: ");
                        do
                        {
                            if (int.TryParse(Console.ReadLine(), out course))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Значення введено не правильно!");
                                Console.Write("Спробуйте зе раз: ");
                            }
                        } while (!int.TryParse(Console.ReadLine(), out course));
                        Console.Write("Введіть вищий навчальний заклад студента: "); institution_of_higher_education = Console.ReadLine();

                        SecondtConstructorStudent = new Student(name, surname, course, institution_of_higher_education);
                        // Set методи
                        SecondtConstructorStudent.SetName(name); SecondtConstructorStudent.SetSurname(surname);
                        SecondtConstructorStudent.SetСourse(course); SecondtConstructorStudent.SetInstitutionOfHigherEducation(institution_of_higher_education);

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                // конструктор з параметрами (2)
                case 3:
                    {
                        int course; string group, faculty, institution_of_higher_education;
                        string name, surname, birthday;
                        Console.Write("Введіть ім'я студента: "); name = Console.ReadLine();
                        Console.Write("Введіть прізвище студента: "); surname = Console.ReadLine();
                        Console.Write("Введіть день народження студента: "); birthday = Console.ReadLine();
                        Console.Write("Введіть номер курсу студента: ");
                        do
                        {
                            if (int.TryParse(Console.ReadLine(), out course))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Значення введено не правильно!");
                                Console.Write("Спробуйте зе раз: ");
                            }
                        } while (!int.TryParse(Console.ReadLine(), out course));
                        Console.Write("Введіть групу студента: "); group = Console.ReadLine();
                        Console.Write("Введіть факультет студента: "); faculty = Console.ReadLine();
                        Console.Write("Введіть вищий навчальний заклад студента: "); institution_of_higher_education = Console.ReadLine();

                        ThirdConstructorStudent = new Student(name, surname, birthday, course, group, faculty, institution_of_higher_education);
                        // Set методи
                        ThirdConstructorStudent.SetName(name); ThirdConstructorStudent.SetSurname(surname); ThirdConstructorStudent.SetBirthday(birthday);
                        ThirdConstructorStudent.SetСourse(course); ThirdConstructorStudent.SetGroup(group);
                        ThirdConstructorStudent.SetFaculty(faculty); ThirdConstructorStudent.SetInstitutionOfHigherEducation(institution_of_higher_education);

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
            }
        }

        static public void CreateEnrollee(ref Enrollee FirstConstructorEnrollee, ref Enrollee SecondtConstructorEnrollee, ref Enrollee ThirdConstructorEnrollee, int ChooseInput)
        {
            int count_EIT_results, result;
            switch (ChooseInput)
            {
                // конструктор по замовчуванню
                case 1:
                    {
                        FirstConstructorEnrollee = new Enrollee();

                        Console.Write("Введіть кількість результатів абітурієнта: ");
                        do
                        {
                            if (int.TryParse(Console.ReadLine(), out count_EIT_results))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Значення введено не правильно!");
                                Console.Write("Спробуйте зе раз: ");
                            }
                        } while (!int.TryParse(Console.ReadLine(), out count_EIT_results));

                        FirstConstructorEnrollee.ResultsEITCertificates = new int[count_EIT_results];

                        Random random = new Random();
                        for (int i = 0; i < count_EIT_results; i++)
                        {
                            FirstConstructorEnrollee.ResultsEITCertificates[i] = result = random.Next(0, 200);
                        }
                        // Set методи
                        FirstConstructorEnrollee.SetResultsEITCertificates(FirstConstructorEnrollee.ResultsEITCertificates);

                        Console.WriteLine("Об'єкт створено!");
                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                // конструктор з параметрами (1)
                case 2:
                    {
                        double number_of_points;
                        string name, surname;
                        Console.Write("Введіть ім'я абітурієнта: "); name = Console.ReadLine();
                        Console.Write("Введіть прізвище абітурієнта: "); surname = Console.ReadLine();
                        Console.Write("Введіть кількість балів за документ про освіту абітурієнта: ");
                        do
                        {
                            if (double.TryParse(Console.ReadLine(), out number_of_points))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Значення введено не правильно!");
                                Console.Write("Спробуйте зе раз: ");
                            }
                        } while (!double.TryParse(Console.ReadLine(), out number_of_points));

                        SecondtConstructorEnrollee = new Enrollee(name, surname, number_of_points);
                        Console.Write("Введіть кількість результатів абітурієнта: ");
                        do
                        {
                            if (int.TryParse(Console.ReadLine(), out count_EIT_results))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Значення введено не правильно!");
                                Console.Write("Спробуйте зе раз: ");
                            }
                        } while (!int.TryParse(Console.ReadLine(), out count_EIT_results));

                        SecondtConstructorEnrollee.ResultsEITCertificates = new int[count_EIT_results];

                        Random random = new Random();
                        for (int i = 0; i < count_EIT_results; i++)
                        {
                            SecondtConstructorEnrollee.ResultsEITCertificates[i] = result = random.Next(0, 200);
                        }
                        // Set методи
                        SecondtConstructorEnrollee.SetName(name); SecondtConstructorEnrollee.SetSurname(surname);
                        SecondtConstructorEnrollee.SetResultsEITCertificates(SecondtConstructorEnrollee.ResultsEITCertificates);
                        SecondtConstructorEnrollee.SetNumberOfPoints(number_of_points);
                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                // конструктор з параметрами (2)
                case 3:
                    {
                        double number_of_points; string name_of_institution_of_higher_education;
                        string name, surname, birthday;
                        Console.Write("Введіть ім'я абітурієнта: "); name = Console.ReadLine();
                        Console.Write("Введіть прізвище абітурієнта: "); surname = Console.ReadLine();
                        Console.Write("Введіть день народження абітурієнта: "); birthday = Console.ReadLine();
                        Console.Write("Введіть кількість балів за документ про освіту абітурієнта: ");
                        do
                        {
                            if (double.TryParse(Console.ReadLine(), out number_of_points))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Значення введено не правильно!");
                                Console.Write("Спробуйте зе раз: ");
                            }
                        } while (!double.TryParse(Console.ReadLine(), out number_of_points));
                        Console.Write("Введіть назву загальноосвітнього навчального закладу: "); name_of_institution_of_higher_education = Console.ReadLine();

                        ThirdConstructorEnrollee = new Enrollee(name, surname, birthday, number_of_points, name_of_institution_of_higher_education);

                        Console.Write("Введіть кількість результатів абітурієнта: ");
                        do
                        {
                            if (int.TryParse(Console.ReadLine(), out count_EIT_results))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Значення введено не правильно!");
                                Console.Write("Спробуйте зе раз: ");
                            }
                        } while (!int.TryParse(Console.ReadLine(), out count_EIT_results));

                        ThirdConstructorEnrollee.ResultsEITCertificates = new int[count_EIT_results];

                        Random random = new Random();
                        for (int i = 0; i < count_EIT_results; i++)
                        {
                            ThirdConstructorEnrollee.ResultsEITCertificates[i] = result = random.Next(0, 200);
                        }
                        // Set методи
                        ThirdConstructorEnrollee.SetName(name); ThirdConstructorEnrollee.SetSurname(surname); ThirdConstructorEnrollee.SetBirthday(birthday);
                        ThirdConstructorEnrollee.SetResultsEITCertificates(ThirdConstructorEnrollee.ResultsEITCertificates);
                        ThirdConstructorEnrollee.SetNumberOfPoints(number_of_points);
                        ThirdConstructorEnrollee.SetNameOfInstitutionOfHigherEducation(name_of_institution_of_higher_education);

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
            }
        }

        static public void CreateTeacher(ref Teacher FirstConstructorTeacher, ref Teacher SecondtConstructorTeacher, ref Teacher ThirdConstructorTeacher, int ChooseInput)
        {
            switch (ChooseInput)
            {
                // конструктор по замовчуванню
                case 1:
                    {
                        FirstConstructorTeacher = new Teacher();

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                // конструктор з параметрами (1)
                case 2:
                    {
                        string position, department;
                        string name, surname;
                        Console.Write("Введіть ім'я вчителя: "); name = Console.ReadLine();
                        Console.Write("Введіть прізвище вчителя: "); surname = Console.ReadLine();
                        Console.Write("Введіть посаду вчителя: "); position = Console.ReadLine();
                        Console.Write("Введіть кафедру вчителя: "); department = Console.ReadLine();

                        SecondtConstructorTeacher = new Teacher(name, surname, position, department);
                        // Set методи
                        SecondtConstructorTeacher.SetName(name); SecondtConstructorTeacher.SetSurname(surname);
                        SecondtConstructorTeacher.SetPosition(position); SecondtConstructorTeacher.SetDepartment(department);

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                // конструктор з параметрами (2)
                case 3:
                    {
                        string position, department, institution_of_higher_education;
                        string name, surname, birthday;
                        Console.Write("Введіть ім'я вчителя: "); name = Console.ReadLine();
                        Console.Write("Введіть прізвище вчителя: "); surname = Console.ReadLine();
                        Console.Write("Введіть день народження вчителя: "); birthday = Console.ReadLine();
                        Console.Write("Введіть посаду вчителя: "); position = Console.ReadLine();
                        Console.Write("Введіть кафедру вчителя: "); department = Console.ReadLine();
                        Console.Write("Введіть вищий навчальний заклад вчителя: "); institution_of_higher_education = Console.ReadLine();

                        ThirdConstructorTeacher = new Teacher(name, surname, birthday, position, department, institution_of_higher_education);
                        // Set методи
                        ThirdConstructorTeacher.SetName(name); ThirdConstructorTeacher.SetSurname(surname); ThirdConstructorTeacher.SetBirthday(birthday);
                        ThirdConstructorTeacher.SetPosition(position); ThirdConstructorTeacher.SetDepartment(department); ThirdConstructorTeacher.SetInstitutionOfHigherEducation(institution_of_higher_education);

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
            }
        }

        static public void CreateLibraryUser(ref LibraryUser FirstConstructorLibraryUser, ref LibraryUser SecondtConstructorLibraryUser, ref LibraryUser ThirdConstructorLibraryUser, int ChooseInput)
        {
            switch (ChooseInput)
            {
                // конструктор по замовчуванню
                case 1:
                    {
                        FirstConstructorLibraryUser = new LibraryUser();

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                // конструктор з параметрами (1)
                case 2:
                    {
                        int readers_ticket_number; string date_of_issue;
                        string name, surname;
                        Console.Write("Введіть ім'я користувача бібліотеки: "); name = Console.ReadLine();
                        Console.Write("Введіть прізвище користувача бібліотеки: "); surname = Console.ReadLine();
                        Console.Write("Введіть номер читацького квитка користувача бібліотеки: ");
                        do
                        {
                            if (int.TryParse(Console.ReadLine(), out readers_ticket_number))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Значення введено не правильно!");
                                Console.Write("Спробуйте зе раз: ");
                            }
                        } while (!int.TryParse(Console.ReadLine(), out readers_ticket_number));
                        Console.Write("Введіть дату видачі користувача бібліотеки: "); date_of_issue = Console.ReadLine();

                        SecondtConstructorLibraryUser = new LibraryUser(name, surname, readers_ticket_number, date_of_issue);
                        // Set методи
                        SecondtConstructorLibraryUser.SetName(name); SecondtConstructorLibraryUser.SetSurname(surname);
                        SecondtConstructorLibraryUser.SetReadersTicketNumber(readers_ticket_number);
                        SecondtConstructorLibraryUser.SetDateOfIssue(date_of_issue);

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
                // конструктор з параметрами (2)
                case 3:
                    {
                        int readers_ticket_number; string date_of_issue; double amount_of_monthly_readers_fee;
                        string name, surname, birthday;
                        Console.Write("Введіть ім'я користувача бібліотеки: "); name = Console.ReadLine();
                        Console.Write("Введіть прізвище користувача бібліотеки: "); surname = Console.ReadLine();
                        Console.Write("Введіть день народження користувача бібліотеки: "); birthday = Console.ReadLine();
                        Console.Write("Введіть номер читацького квитка користувача бібліотеки: ");
                        do
                        {
                            if (int.TryParse(Console.ReadLine(), out readers_ticket_number))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Значення введено не правильно!");
                                Console.Write("Спробуйте зе раз: ");
                            }
                        } while (!int.TryParse(Console.ReadLine(), out readers_ticket_number));
                        Console.Write("Введіть дату видачі користувача бібліотеки: "); date_of_issue = Console.ReadLine();
                        Console.Write("Введіть розмір щомісячного читацького внеску користувача бібліотеки: ");
                        do
                        {
                            if (double.TryParse(Console.ReadLine(), out amount_of_monthly_readers_fee))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Помилка! Значення введено не правильно!");
                                Console.Write("Спробуйте зе раз: ");
                            }
                        } while (!double.TryParse(Console.ReadLine(), out amount_of_monthly_readers_fee));

                        ThirdConstructorLibraryUser = new LibraryUser(name, surname, birthday, readers_ticket_number, date_of_issue, amount_of_monthly_readers_fee);
                        // Set методи
                        ThirdConstructorLibraryUser.SetName(name); ThirdConstructorLibraryUser.SetSurname(surname); ThirdConstructorLibraryUser.SetBirthday(birthday);
                        ThirdConstructorLibraryUser.SetReadersTicketNumber(readers_ticket_number);
                        ThirdConstructorLibraryUser.SetDateOfIssue(date_of_issue);
                        ThirdConstructorLibraryUser.SetAmountOfMonthlyReadersFee(amount_of_monthly_readers_fee);

                        Console.WriteLine("Об'єкт створено!");

                        Console.Write("Натисніть ENTER для продовження... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }
            }
        }


        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            int Choise, ChooseTask, ChooseInput, ChooseGetMethod, ChooseOutput;
            Human FirstConstructorHuman = null; Human SecondtConstructorHuman = null; Human ThirdConstructorHuman = null;
            Student FirstConstructorStudent = null; Student SecondtConstructorStudent = null; Student ThirdConstructorStudent = null;
            Enrollee FirstConstructorEnrollee = null; Enrollee SecondtConstructorEnrollee = null; Enrollee ThirdConstructorEnrollee = null;
            Teacher FirstConstructorTeacher = null; Teacher SecondtConstructorTeacher = null; Teacher ThirdConstructorTeacher = null;
            LibraryUser FirstConstructorLibraryUser = null; LibraryUser SecondtConstructorLibraryUser = null; LibraryUser ThirdConstructorLibraryUser = null;

            do
            {
                Console.Title = "Практична робота 08";
                Console.WriteLine("Практична робота 08 (24.02.2023). Тема: Наслідування у C#");
                Console.WriteLine("\nСтворення об'єктів классів з бібліотеки класів, використання Set методів та конструкторів. (1)");
                Console.WriteLine("\n                                                       Використавння Get методів у класах. (2)");
                Console.WriteLine("\n             Вивід інформації за допомогою віртуального метода SortInfo у головному класі. (3)");

                Console.Write("\nВведіть номер завдання який хочете виконати (0 - вихід із програми): ");
                if (int.TryParse(Console.ReadLine(), out Choise) && Choise >= 0 && Choise <= 3)
                {
                    switch (Choise)
                    {
                        // Закінчення виконання програми
                        case 0:
                            {
                                Console.Title = "Виконання програми завершено!";
                                Console.WriteLine("\nВиконання програми завершено! Дякую за увагу. Україна переможе!");
                                break;
                            }
                        // Створення об'єктів классів з бібліотеки класів та використання конструкторів.
                        case 1:
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.Title = "Створення об'єктів классів";

                                    Console.WriteLine("      Створення об'єкта класа типу Human. (1)");
                                    Console.WriteLine("    Створення об'єкта класа типу Student. (2)");
                                    Console.WriteLine("   Створення об'єкта класу типу Enrollee. (3)");
                                    Console.WriteLine("    Створення об'єкта класу типу Teacher. (4)");
                                    Console.WriteLine("Створення об'єкта класу типу LibraryUser. (5)");

                                    Console.Write("\nВведіть який об'єкт хочете створити(0 - вийти до головного меню): ");

                                    if (int.TryParse(Console.ReadLine(), out ChooseTask) && ChooseTask >= 0 && ChooseTask <= 5)
                                    {
                                        switch (ChooseTask)
                                        {
                                            // вихід з підменю
                                            case 0:
                                                {
                                                    Console.WriteLine("Ви вийшли з меню створення об'єктів класів!");
                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // Create - Human
                                            case 1:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Конструктор класу по замовчуванню. (1)");
                                                        Console.WriteLine("Перший конструктор класу з параметрами. (2)");
                                                        Console.WriteLine("Другий конструктор класу з параметрами. (3)");
                                                        Console.WriteLine("            Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯкий з конструкторів бажаєте використати: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseInput) && ChooseInput >= 0 && ChooseInput <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseInput) && ChooseInput >= 0 && ChooseInput <= 3);

                                                        CreateHuman(ref FirstConstructorHuman, ref SecondtConstructorHuman, ref ThirdConstructorHuman, ChooseInput);

                                                    } while (ChooseInput != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // Create - Student
                                            case 2:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Конструктор класу по замовчуванню. (1)");
                                                        Console.WriteLine("Перший конструктор класу з параметрами. (2)");
                                                        Console.WriteLine("Другий конструктор класу з параметрами. (3)");
                                                        Console.WriteLine("            Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯкий з конструкторів бажаєте використати: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseInput) && ChooseInput >= 0 && ChooseInput <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseInput) && ChooseInput >= 0 && ChooseInput <= 3);

                                                        CreateStudent(ref FirstConstructorStudent, ref SecondtConstructorStudent, ref ThirdConstructorStudent, ChooseInput);

                                                    } while (ChooseInput != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // Create - Enrollee
                                            case 3:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Конструктор класу по замовчуванню. (1)");
                                                        Console.WriteLine("Перший конструктор класу з параметрами. (2)");
                                                        Console.WriteLine("Другий конструктор класу з параметрами. (3)");
                                                        Console.WriteLine("            Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯкий з конструкторів бажаєте використати: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseInput) && ChooseInput >= 0 && ChooseInput <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseInput) && ChooseInput >= 0 && ChooseInput <= 3);

                                                        CreateEnrollee(ref FirstConstructorEnrollee, ref SecondtConstructorEnrollee, ref ThirdConstructorEnrollee, ChooseInput);

                                                    } while (ChooseInput != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // Create - Teacher
                                            case 4:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Конструктор класу по замовчуванню. (1)");
                                                        Console.WriteLine("Перший конструктор класу з параметрами. (2)");
                                                        Console.WriteLine("Другий конструктор класу з параметрами. (3)");
                                                        Console.WriteLine("            Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯкий з конструкторів бажаєте використати: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseInput) && ChooseInput >= 0 && ChooseInput <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseInput) && ChooseInput >= 0 && ChooseInput <= 3);

                                                        CreateTeacher(ref FirstConstructorTeacher, ref SecondtConstructorTeacher, ref ThirdConstructorTeacher, ChooseInput);

                                                    } while (ChooseInput != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // Create - LibraryUser
                                            case 5:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Конструктор класу по замовчуванню. (1)");
                                                        Console.WriteLine("Перший конструктор класу з параметрами. (2)");
                                                        Console.WriteLine("Другий конструктор класу з параметрами. (3)");
                                                        Console.WriteLine("            Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯкий з конструкторів бажаєте використати: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseInput) && ChooseInput >= 0 && ChooseInput <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseInput) && ChooseInput >= 0 && ChooseInput <= 3);

                                                        CreateLibraryUser(ref FirstConstructorLibraryUser, ref SecondtConstructorLibraryUser, ref ThirdConstructorLibraryUser, ChooseInput);

                                                    } while (ChooseInput != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nПОМИЛКА! Номер завдання введено не правильно.");
                                        Console.Write("Натисніть ENTER для продовження... ");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                } while (ChooseTask != 0);
                                break;
                            }
                        //  Використавння Get методів у класах. 
                        case 2:
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.Title = "Get методи.";

                                    Console.WriteLine("      Використати Get-методи класа типу Human. (1)");
                                    Console.WriteLine("    Використати Get-методи класа типу Student. (2)");
                                    Console.WriteLine("   Використати Get-методи класу типу Enrollee. (3)");
                                    Console.WriteLine("    Використати Get-методи класу типу Teacher. (4)");
                                    Console.WriteLine("Використати Get-методи класу типу LibraryUser. (5)");

                                    Console.Write("\nВведіть у якому класі хочете використати Get-методи(0 - вийти до головного меню): ");

                                    if (int.TryParse(Console.ReadLine(), out ChooseTask) && ChooseTask >= 0 && ChooseTask <= 5)
                                    {
                                        switch (ChooseTask)
                                        {
                                            // вихід з підменю
                                            case 0:
                                                {
                                                    Console.WriteLine("Ви вийшли з меню використання Get-методів класів!");
                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // Get-методи - Human
                                            case 1:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Get-метод об'єкту який створив конструктор класу по замовчуванню. (1)");
                                                        Console.WriteLine("Get-метод об'єкту який створив перший конструктор класу з параметрами. (2)");
                                                        Console.WriteLine("Get-метод об'єкту який створив другий конструктор класу з параметрами. (3)");
                                                        Console.WriteLine("                                           Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯкий з Get-методів бажаєте використати: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseGetMethod) && ChooseGetMethod >= 0 && ChooseGetMethod <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseGetMethod) && ChooseGetMethod >= 0 && ChooseGetMethod <= 3);

                                                        switch (ChooseGetMethod)
                                                        {
                                                            case 1:
                                                                {
                                                                    Console.WriteLine($"Ім'я людини: {FirstConstructorHuman.GetName()}");
                                                                    Console.WriteLine($"Прізвище людини: {FirstConstructorHuman.GetSurname()}");
                                                                    Console.WriteLine($"День народження людини: {FirstConstructorHuman.GetBirthday()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    Console.WriteLine($"Ім'я людини: {SecondtConstructorHuman.GetName()}");
                                                                    Console.WriteLine($"Прізвище людини: {SecondtConstructorHuman.GetSurname()}");
                                                                    Console.WriteLine($"День народження людини: {SecondtConstructorHuman.GetBirthday()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    Console.WriteLine($"Ім'я людини: {ThirdConstructorHuman.GetName()}");
                                                                    Console.WriteLine($"Прізвище людини: {ThirdConstructorHuman.GetSurname()}");
                                                                    Console.WriteLine($"День народження людини: {ThirdConstructorHuman.GetBirthday()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                        }

                                                    } while (ChooseGetMethod != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // Get-методи - Student
                                            case 2:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Get-метод об'єкту який створив конструктор класу по замовчуванню. (1)");
                                                        Console.WriteLine("Get-метод об'єкту який створив перший конструктор класу з параметрами. (2)");
                                                        Console.WriteLine("Get-метод об'єкту який створив другий конструктор класу з параметрами. (3)");
                                                        Console.WriteLine("                                           Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯкий з Get-методів бажаєте використати: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseGetMethod) && ChooseGetMethod >= 0 && ChooseGetMethod <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseGetMethod) && ChooseGetMethod >= 0 && ChooseGetMethod <= 3);

                                                        switch (ChooseGetMethod)
                                                        {
                                                            case 1:
                                                                {
                                                                    Console.WriteLine($"Ім'я студента: {FirstConstructorStudent.GetName()}");
                                                                    Console.WriteLine($"Прізвище студента: {FirstConstructorStudent.GetSurname()}");
                                                                    Console.WriteLine($"День народження студента: {FirstConstructorStudent.GetBirthday()}");
                                                                    Console.WriteLine($"Курс студента: {FirstConstructorStudent.GetСourse()}");
                                                                    Console.WriteLine($"Група студента: {FirstConstructorStudent.GetGroup()}");
                                                                    Console.WriteLine($"Факультет студента: {FirstConstructorStudent.GetFaculty()}");
                                                                    Console.WriteLine($"Вищий навчальний заклад студента: {FirstConstructorStudent.GetInstitutionOfHigherEducation()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    Console.WriteLine($"Ім'я студента: {SecondtConstructorStudent.GetName()}");
                                                                    Console.WriteLine($"Прізвище студента: {SecondtConstructorStudent.GetSurname()}");
                                                                    Console.WriteLine($"День народження студента: {SecondtConstructorStudent.GetBirthday()}");
                                                                    Console.WriteLine($"Курс студента: {SecondtConstructorStudent.GetСourse()}");
                                                                    Console.WriteLine($"Група студента: {SecondtConstructorStudent.GetGroup()}");
                                                                    Console.WriteLine($"Факультет студента: {SecondtConstructorStudent.GetFaculty()}");
                                                                    Console.WriteLine($"Вищий навчальний заклад студента: {SecondtConstructorStudent.GetInstitutionOfHigherEducation()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    Console.WriteLine($"Ім'я студента: {ThirdConstructorStudent.GetName()}");
                                                                    Console.WriteLine($"Прізвище студента: {ThirdConstructorStudent.GetSurname()}");
                                                                    Console.WriteLine($"День народження студента: {ThirdConstructorStudent.GetBirthday()}");
                                                                    Console.WriteLine($"Курс студента: {ThirdConstructorStudent.GetСourse()}");
                                                                    Console.WriteLine($"Група студента: {ThirdConstructorStudent.GetGroup()}");
                                                                    Console.WriteLine($"Факультет студента: {ThirdConstructorStudent.GetFaculty()}");
                                                                    Console.WriteLine($"Вищий навчальний заклад студента: {ThirdConstructorStudent.GetInstitutionOfHigherEducation()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                        }

                                                    } while (ChooseGetMethod != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // Get-методи - Enrollee
                                            case 3:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Get-метод об'єкту який створив конструктор класу по замовчуванню. (1)");
                                                        Console.WriteLine("Get-метод об'єкту який створив перший конструктор класу з параметрами. (2)");
                                                        Console.WriteLine("Get-метод об'єкту який створив другий конструктор класу з параметрами. (3)");
                                                        Console.WriteLine("                                           Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯкий з Get-методів бажаєте використати: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseGetMethod) && ChooseGetMethod >= 0 && ChooseGetMethod <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseGetMethod) && ChooseGetMethod >= 0 && ChooseGetMethod <= 3);

                                                        switch (ChooseGetMethod)
                                                        {
                                                            case 1:
                                                                {
                                                                    Console.WriteLine($"Ім'я абітурієнта: {FirstConstructorEnrollee.GetName()}");
                                                                    Console.WriteLine($"Прізвище абітурієнта: {FirstConstructorEnrollee.GetSurname()}");
                                                                    Console.WriteLine($"День народження абітурієнта: {FirstConstructorEnrollee.GetBirthday()}");
                                                                    Console.WriteLine($"Кількість балів сертифікатів ЗНО абітурієнта: ");
                                                                    for (int i = 0; i < FirstConstructorEnrollee.ResultsEITCertificates.Length; i++)
                                                                    {
                                                                        Console.WriteLine($"Оцінка за {i + 1} сертифікат: {FirstConstructorEnrollee.GetResultsEITCertificates(i)}");
                                                                    }
                                                                    Console.WriteLine($"Кількість балів за документ про освіту абітурієнта: {FirstConstructorEnrollee.GetNumberOfPoints()}");
                                                                    Console.WriteLine($"Назва загальноосвітнього навчального закладу абітурієнта: {FirstConstructorEnrollee.GetNameOfInstitutionOfHigherEducation()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    Console.WriteLine($"Ім'я абітурієнта: {SecondtConstructorEnrollee.GetName()}");
                                                                    Console.WriteLine($"Прізвище абітурієнта: {SecondtConstructorEnrollee.GetSurname()}");
                                                                    Console.WriteLine($"День народження абітурієнта: {SecondtConstructorEnrollee.GetBirthday()}");
                                                                    Console.WriteLine($"Кількість балів сертифікатів ЗНО абітурієнта: ");
                                                                    for (int i = 0; i < SecondtConstructorEnrollee.ResultsEITCertificates.Length; i++)
                                                                    {
                                                                        Console.WriteLine($"Оцінка за {i + 1} сертифікат: {SecondtConstructorEnrollee.GetResultsEITCertificates(i)}");
                                                                    }
                                                                    Console.WriteLine($"Кількість балів за документ про освіту абітурієнта: {SecondtConstructorEnrollee.GetNumberOfPoints()}");
                                                                    Console.WriteLine($"Назва загальноосвітнього навчального закладу абітурієнта: {SecondtConstructorEnrollee.GetNameOfInstitutionOfHigherEducation()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    Console.WriteLine($"Ім'я абітурієнта: {ThirdConstructorEnrollee.GetName()}");
                                                                    Console.WriteLine($"Прізвище абітурієнта: {ThirdConstructorEnrollee.GetSurname()}");
                                                                    Console.WriteLine($"День народження абітурієнта: {ThirdConstructorEnrollee.GetBirthday()}");
                                                                    Console.WriteLine($"Кількість балів сертифікатів ЗНО абітурієнта: ");
                                                                    for (int i = 0; i < ThirdConstructorEnrollee.ResultsEITCertificates.Length; i++)
                                                                    {
                                                                        Console.WriteLine($"Оцінка за {i + 1} сертифікат: {ThirdConstructorEnrollee.GetResultsEITCertificates(i)}");
                                                                    }
                                                                    Console.WriteLine($"Кількість балів за документ про освіту абітурієнта: {ThirdConstructorEnrollee.GetNumberOfPoints()}");
                                                                    Console.WriteLine($"Назва загальноосвітнього навчального закладу абітурієнта: {ThirdConstructorEnrollee.GetNameOfInstitutionOfHigherEducation()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                        }

                                                    } while (ChooseGetMethod != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // Get-методи - Teacher
                                            case 4:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Get-метод об'єкту який створив конструктор класу по замовчуванню. (1)");
                                                        Console.WriteLine("Get-метод об'єкту який створив перший конструктор класу з параметрами. (2)");
                                                        Console.WriteLine("Get-метод об'єкту який створив другий конструктор класу з параметрами. (3)");
                                                        Console.WriteLine("                                           Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯкий з Get-методів бажаєте використати: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseGetMethod) && ChooseGetMethod >= 0 && ChooseGetMethod <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseGetMethod) && ChooseGetMethod >= 0 && ChooseGetMethod <= 3);

                                                        switch (ChooseGetMethod)
                                                        {
                                                            case 1:
                                                                {
                                                                    Console.WriteLine($"Ім'я вчителя: {FirstConstructorTeacher.GetName()}");
                                                                    Console.WriteLine($"Прізвище вчителя: {FirstConstructorTeacher.GetSurname()}");
                                                                    Console.WriteLine($"День народження вчителя: {FirstConstructorTeacher.GetBirthday()}");
                                                                    Console.WriteLine($"Посада вчителя: {FirstConstructorTeacher.GetPosition()}");
                                                                    Console.WriteLine($"Кафедра вчителя: {FirstConstructorTeacher.GetDepartment()}");
                                                                    Console.WriteLine($"Вищий навчальний заклад вчителя: {FirstConstructorTeacher.GetInstitutionOfHigherEducation()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    Console.WriteLine($"Ім'я вчителя: {SecondtConstructorTeacher.GetName()}");
                                                                    Console.WriteLine($"Прізвище вчителя: {SecondtConstructorTeacher.GetSurname()}");
                                                                    Console.WriteLine($"День народження вчителя: {SecondtConstructorTeacher.GetBirthday()}");
                                                                    Console.WriteLine($"Посада вчителя: {SecondtConstructorTeacher.GetPosition()}");
                                                                    Console.WriteLine($"Кафедра вчителя: {SecondtConstructorTeacher.GetDepartment()}");
                                                                    Console.WriteLine($"Вищий навчальний заклад вчителя: {SecondtConstructorTeacher.GetInstitutionOfHigherEducation()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    Console.WriteLine($"Ім'я вчителя: {ThirdConstructorTeacher.GetName()}");
                                                                    Console.WriteLine($"Прізвище вчителя: {ThirdConstructorTeacher.GetSurname()}");
                                                                    Console.WriteLine($"День народження вчителя: {ThirdConstructorTeacher.GetBirthday()}");
                                                                    Console.WriteLine($"Посада вчителя: {ThirdConstructorTeacher.GetPosition()}");
                                                                    Console.WriteLine($"Кафедра вчителя: {ThirdConstructorTeacher.GetDepartment()}");
                                                                    Console.WriteLine($"Вищий навчальний заклад вчителя: {ThirdConstructorTeacher.GetInstitutionOfHigherEducation()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                        }

                                                    } while (ChooseGetMethod != 0);
                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // Get-методи - LibraryUser
                                            case 5:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Get-метод об'єкту який створив конструктор класу по замовчуванню. (1)");
                                                        Console.WriteLine("Get-метод об'єкту який створив перший конструктор класу з параметрами. (2)");
                                                        Console.WriteLine("Get-метод об'єкту який створив другий конструктор класу з параметрами. (3)");
                                                        Console.WriteLine("                                           Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯкий з Get-методів бажаєте використати: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseGetMethod) && ChooseGetMethod >= 0 && ChooseGetMethod <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseGetMethod) && ChooseGetMethod >= 0 && ChooseGetMethod <= 3);

                                                        switch (ChooseGetMethod)
                                                        {
                                                            case 1:
                                                                {
                                                                    Console.WriteLine($"Ім'я користувача бібліотеки: {FirstConstructorLibraryUser.GetName()}");
                                                                    Console.WriteLine($"Прізвище користувача бібліотеки: {FirstConstructorLibraryUser.GetSurname()}");
                                                                    Console.WriteLine($"День народження користувача бібліотеки: {FirstConstructorLibraryUser.GetBirthday()}");
                                                                    Console.WriteLine($"Номер читацького квитка користувача бібліотеки: {FirstConstructorLibraryUser.GetReadersTicketNumber()}");
                                                                    Console.WriteLine($"Дата видачі користувача бібліотеки: {FirstConstructorLibraryUser.GetDateOfIssue()}");
                                                                    Console.WriteLine($"Розмір щомісячного читацького внеску користувача бібліотеки: {FirstConstructorLibraryUser.GetAmountOfMonthlyReadersFee()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    Console.WriteLine($"Ім'я користувача бібліотеки: {SecondtConstructorLibraryUser.GetName()}");
                                                                    Console.WriteLine($"Прізвище користувача бібліотеки: {SecondtConstructorLibraryUser.GetSurname()}");
                                                                    Console.WriteLine($"День народження користувача бібліотеки: {SecondtConstructorLibraryUser.GetBirthday()}");
                                                                    Console.WriteLine($"Номер читацького квитка користувача бібліотеки: {SecondtConstructorLibraryUser.GetReadersTicketNumber()}");
                                                                    Console.WriteLine($"Дата видачі користувача бібліотеки: {SecondtConstructorLibraryUser.GetDateOfIssue()}");
                                                                    Console.WriteLine($"Розмір щомісячного читацького внеску користувача бібліотеки: {SecondtConstructorLibraryUser.GetAmountOfMonthlyReadersFee()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    Console.WriteLine($"Ім'я користувача бібліотеки: {ThirdConstructorLibraryUser.GetName()}");
                                                                    Console.WriteLine($"Прізвище користувача бібліотеки: {ThirdConstructorLibraryUser.GetSurname()}");
                                                                    Console.WriteLine($"День народження користувача бібліотеки: {ThirdConstructorLibraryUser.GetBirthday()}");
                                                                    Console.WriteLine($"Номер читацького квитка користувача бібліотеки: {ThirdConstructorLibraryUser.GetReadersTicketNumber()}");
                                                                    Console.WriteLine($"Дата видачі користувача бібліотеки: {ThirdConstructorLibraryUser.GetDateOfIssue()}");
                                                                    Console.WriteLine($"Розмір щомісячного читацького внеску користувача бібліотеки: {ThirdConstructorLibraryUser.GetAmountOfMonthlyReadersFee()}");
                                                                    Console.WriteLine("\nВикористання Get-методів завершено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    break;
                                                                }
                                                        }

                                                    } while (ChooseGetMethod != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nПОМИЛКА! Номер завдання введено не правильно.");
                                        Console.Write("Натисніть ENTER для продовження... ");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                } while (ChooseTask != 0);

                                break;
                            }
                        // Вивід інформації за допомогою віртуального метода SortInfo у головному класі.
                        case 3:
                            {
                                do
                                {
                                    Console.Clear();
                                    Console.Title = "Віртуальний метод SortInfo у головному класі.";

                                    Console.WriteLine("      Виведення об'єкта класа типу Human. (1)");
                                    Console.WriteLine("    Виведення об'єкта класа типу Student. (2)");
                                    Console.WriteLine("   Виведення об'єкта класу типу Enrollee. (3)");
                                    Console.WriteLine("    Виведення об'єкта класу типу Teacher. (4)");
                                    Console.WriteLine("Виведення об'єкта класу типу LibraryUser. (5)");

                                    Console.Write("\nВведіть який об'єкт хочете вивести за допомогою SortInfo(0 - вийти до головного меню): ");

                                    if (int.TryParse(Console.ReadLine(), out ChooseTask) && ChooseTask >= 0 && ChooseTask <= 5)
                                    {
                                        switch (ChooseTask)
                                        {
                                            // Вихід з підменю
                                            case 0:
                                                {
                                                    Console.WriteLine("Ви вийшли з меню виведення об'єктів класів за допомогою SortInfo!");
                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // SortInfo - Human 
                                            case 1:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Виведення класу за конструктором по замовчуванню. (1)");
                                                        Console.WriteLine("Виведення класу за першим конструктором з параметрами. (2)");
                                                        Console.WriteLine("Виведення класу за другим конструктором з параметрами. (3)");
                                                        Console.WriteLine("                           Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯке виведення бажаєте здійснити: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseOutput) && ChooseOutput >= 0 && ChooseOutput <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseOutput) && ChooseOutput >= 0 && ChooseOutput <= 3);

                                                        switch (ChooseOutput)
                                                        {
                                                            case 1:
                                                                {
                                                                    FirstConstructorHuman.ShowInfo();

                                                                    Console.WriteLine("\nОб'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    SecondtConstructorHuman.ShowInfo();

                                                                    Console.WriteLine("\nОб'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    ThirdConstructorHuman.ShowInfo();

                                                                    Console.WriteLine("Об'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                        }
                                                    } while (ChooseOutput != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // SortInfo - Student 
                                            case 2:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Виведення класу за конструктором по замовчуванню. (1)");
                                                        Console.WriteLine("Виведення класу за першим конструктором з параметрами. (2)");
                                                        Console.WriteLine("Виведення класу за другим конструктором з параметрами. (3)");
                                                        Console.WriteLine("                           Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯке виведення бажаєте здійснити: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseOutput) && ChooseOutput >= 0 && ChooseOutput <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseOutput) && ChooseOutput >= 0 && ChooseOutput <= 3);

                                                        switch (ChooseOutput)
                                                        {
                                                            case 1:
                                                                {
                                                                    FirstConstructorStudent.ShowInfo();

                                                                    Console.WriteLine("\nОб'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    SecondtConstructorStudent.ShowInfo();

                                                                    Console.WriteLine("\nОб'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    ThirdConstructorStudent.ShowInfo();

                                                                    Console.WriteLine("Об'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                        }
                                                    } while (ChooseOutput != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // SortInfo - Enrollee 
                                            case 3:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Виведення класу за конструктором по замовчуванню. (1)");
                                                        Console.WriteLine("Виведення класу за першим конструктором з параметрами. (2)");
                                                        Console.WriteLine("Виведення класу за другим конструктором з параметрами. (3)");
                                                        Console.WriteLine("                           Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯке виведення бажаєте здійснити: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseOutput) && ChooseOutput >= 0 && ChooseOutput <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseOutput) && ChooseOutput >= 0 && ChooseOutput <= 3);

                                                        switch (ChooseOutput)
                                                        {
                                                            case 1:
                                                                {
                                                                    FirstConstructorEnrollee.ShowInfo();

                                                                    Console.WriteLine("\nОб'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    SecondtConstructorEnrollee.ShowInfo();

                                                                    Console.WriteLine("\nОб'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    ThirdConstructorEnrollee.ShowInfo();

                                                                    Console.WriteLine("Об'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                        }
                                                    } while (ChooseOutput != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // SortInfo - Teacher 
                                            case 4:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Виведення класу за конструктором по замовчуванню. (1)");
                                                        Console.WriteLine("Виведення класу за першим конструктором з параметрами. (2)");
                                                        Console.WriteLine("Виведення класу за другим конструктором з параметрами. (3)");
                                                        Console.WriteLine("                           Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯке виведення бажаєте здійснити: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseOutput) && ChooseOutput >= 0 && ChooseOutput <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseOutput) && ChooseOutput >= 0 && ChooseOutput <= 3);

                                                        switch (ChooseOutput)
                                                        {
                                                            case 1:
                                                                {
                                                                    FirstConstructorTeacher.ShowInfo();

                                                                    Console.WriteLine("\nОб'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    SecondtConstructorTeacher.ShowInfo();

                                                                    Console.WriteLine("\nОб'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    ThirdConstructorTeacher.ShowInfo();

                                                                    Console.WriteLine("Об'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                        }
                                                    } while (ChooseOutput != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                            // SortInfo - LibraryUser 
                                            case 5:
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("     Виведення класу за конструктором по замовчуванню. (1)");
                                                        Console.WriteLine("Виведення класу за першим конструктором з параметрами. (2)");
                                                        Console.WriteLine("Виведення класу за другим конструктором з параметрами. (3)");
                                                        Console.WriteLine("                           Вихід до попереднього меню. (0)");

                                                        Console.Write("\nЯке виведення бажаєте здійснити: ");
                                                        // введення пункту меню для виконання
                                                        do
                                                        {
                                                            if (int.TryParse(Console.ReadLine(), out ChooseOutput) && ChooseOutput >= 0 && ChooseOutput <= 3)
                                                            {
                                                                break;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Помилка! Значення введено не правильно.");
                                                                Console.Write("Спробуйте ще раз: ");
                                                            }

                                                        } while (!int.TryParse(Console.ReadLine(), out ChooseOutput) && ChooseOutput >= 0 && ChooseOutput <= 3);

                                                        switch (ChooseOutput)
                                                        {
                                                            case 1:
                                                                {
                                                                    FirstConstructorLibraryUser.ShowInfo();

                                                                    Console.WriteLine("\nОб'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                            case 2:
                                                                {
                                                                    SecondtConstructorLibraryUser.ShowInfo();

                                                                    Console.WriteLine("\nОб'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                            case 3:
                                                                {
                                                                    ThirdConstructorLibraryUser.ShowInfo();

                                                                    Console.WriteLine("Об'єкт виведено!");
                                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                                    Console.ReadLine();
                                                                    Console.Clear();
                                                                    break;
                                                                }
                                                        }
                                                    } while (ChooseOutput != 0);

                                                    Console.Write("Натисніть ENTER для продовження... ");
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                    break;
                                                }
                                        }
                                    }
                                } while (ChooseTask != 0);

                                Console.Write("Натисніть ENTER для продовження... ");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("\nПОМИЛКА! Номер завдання введено не правильно.");
                    Console.Write("Натисніть ENTER для продовження... ");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (Choise != 0);
        }
    }
}
