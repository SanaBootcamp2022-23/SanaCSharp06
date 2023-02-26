using ClassLibrary;
using System.Text;

System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
               System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
customCulture.NumberFormat.NumberDecimalSeparator = ".";
System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;


int act = 1;
bool check;
People[] PeopleArr;
Entrant[] EntrantArr;
Student[] StudentArr;
Teacher[] TeacherArr;
LibraryUser[] LibraryUserArr;
do
{
    do
    {
        Console.Clear();
        Console.WriteLine("Виберіть з чим бажаєте працювати:");
        Console.WriteLine("1 - Людиною");
        Console.WriteLine("2 - Абітурієнтом");
        Console.WriteLine("3 - Студентом");
        Console.WriteLine("4 - Викладачем");
        Console.WriteLine("5 - Користувачем бібліотеки");
        Console.WriteLine("0 - Завершити роботу");
        check = int.TryParse(Console.ReadLine(), out act);
        if (check == false)
        {
            Console.WriteLine("Помилка при введені. Спробуйте ще раз");
            Console.ReadKey();
        }
    } while (check == false);
    switch (act)
    {
        case 1:
            {
                int n;
                Console.Clear();
                do
                {
                    Console.Write("Введіть кількість людей: ");
                    check = int.TryParse(Console.ReadLine(), out n);
                    if (check == false || n < 1) Console.WriteLine("Помилка. Введіть коректне значення.");
                } while (check == false || n < 1);
                Console.Clear();
                PeopleArr = new People[n];
                for (int i = 0; i < n; i++)
                {
                    PeopleArr[i] = new People();
                    Console.WriteLine($"Людина {i + 1}");
                    Console.Write("Введіть ім'я: ");
                    PeopleArr[i].name = Console.ReadLine();
                    Console.Write("Введіть прізвище: ");
                    PeopleArr[i].surname = Console.ReadLine();
                    Console.Write("Введіть дату народження: ");
                    PeopleArr[i].birthdayDate = Console.ReadLine();
                    Console.Clear();
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Людина {i + 1}");
                    PeopleArr[i].ShowInfo();
                    Console.Write("\n");
                }
                Console.ReadKey();
                break;
            }
        case 2:
            {
                int n;
                Console.Clear();
                do
                {
                    Console.Write("Введіть кількість абітурієнтів: ");
                    check = int.TryParse(Console.ReadLine(), out n);
                    if (check == false || n < 1) Console.WriteLine("Помилка. Введіть коректне значення.");
                } while (check == false || n < 1);
                Console.Clear();
                EntrantArr = new Entrant[n];
                for (int i = 0; i < n; i++)
                {
                    EntrantArr[i] = new Entrant();
                    Console.WriteLine($"Абітурієнт {i + 1}");
                    Console.Write("Введіть ім'я: ");
                    EntrantArr[i].name = Console.ReadLine();
                    Console.Write("Введіть прізвище: ");
                    EntrantArr[i].surname = Console.ReadLine();
                    Console.Write("Введіть дату народження: ");
                    EntrantArr[i].birthdayDate = Console.ReadLine();
                    Console.Write("Введіть оцінку за ЗНО: ");
                    EntrantArr[i].znoMark = int.Parse(Console.ReadLine());
                    Console.Write("Введіть оцінку за атестат: ");
                    EntrantArr[i].schoolMark = int.Parse(Console.ReadLine());
                    Console.Write("Введіть назву школи: ");
                    EntrantArr[i].schoolName = Console.ReadLine();
                    Console.Clear();
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Абітурієнт {i + 1}");
                    EntrantArr[i].ShowInfo();
                    Console.Write("\n");
                }
                Console.ReadKey();
                break;
            }
        case 3:
            {
                int n;
                Console.Clear();
                do
                {
                    Console.Write("Введіть кількість студентів: ");
                    check = int.TryParse(Console.ReadLine(), out n);
                    if (check == false || n < 1) Console.WriteLine("Помилка. Введіть коректне значення.");
                } while (check == false || n < 1);
                Console.Clear();
                StudentArr = new Student[n];
                for (int i = 0; i < n; i++)
                {
                    StudentArr[i] = new Student();
                    Console.WriteLine($"Студент {i + 1}");
                    Console.Write("Введіть ім'я: ");
                    StudentArr[i].name = Console.ReadLine();
                    Console.Write("Введіть прізвище: ");
                    StudentArr[i].surname = Console.ReadLine();
                    Console.Write("Введіть дату народження: ");
                    StudentArr[i].birthdayDate = Console.ReadLine();
                    Console.Write("Введіть курс: ");
                    StudentArr[i].course = int.Parse(Console.ReadLine());
                    Console.Write("Введіть группу: ");
                    StudentArr[i].group = Console.ReadLine();
                    Console.Write("Введіть назву факультету: ");
                    StudentArr[i].faculty = Console.ReadLine();
                    Console.Write("Введіть назву вищого навчального закладу: ");
                    StudentArr[i].studingPlaceName = Console.ReadLine();
                    Console.Clear();
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Студент {i + 1}");
                    StudentArr[i].ShowInfo();
                    Console.Write("\n");
                }
                Console.ReadKey();
                break;
            }
        case 4:
            {
                int n;
                Console.Clear();
                do
                {
                    Console.Write("Введіть кількість викладачів: ");
                    check = int.TryParse(Console.ReadLine(), out n);
                    if (check == false || n < 1) Console.WriteLine("Помилка. Введіть коректне значення.");
                } while (check == false || n < 1);
                Console.Clear();
                TeacherArr = new Teacher[n];
                for (int i = 0; i < n; i++)
                {
                    TeacherArr[i] = new Teacher();
                    Console.WriteLine($"Викладач {i + 1}");
                    Console.Write("Введіть ім'я: ");
                    TeacherArr[i].name = Console.ReadLine();
                    Console.Write("Введіть прізвище: ");
                    TeacherArr[i].surname = Console.ReadLine();
                    Console.Write("Введіть дату народження: ");
                    TeacherArr[i].birthdayDate = Console.ReadLine();
                    Console.Write("Введіть посаду: ");
                    TeacherArr[i].workPlace = Console.ReadLine();
                    Console.Write("Введіть назву кафедри: ");
                    TeacherArr[i].department = Console.ReadLine();
                    Console.Write("Введіть назву вищого навчального закладу: ");
                    TeacherArr[i].studingPlaceName = Console.ReadLine();
                    Console.Clear();
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Викладач {i + 1}");
                    TeacherArr[i].ShowInfo();
                    Console.Write("\n");
                }
                Console.ReadKey();
                break;
            }
        case 5:
            {
                int n;
                Console.Clear();
                do
                {
                    Console.Write("Введіть кількість користувачів бібліотеки: ");
                    check = int.TryParse(Console.ReadLine(), out n);
                    if (check == false || n < 1) Console.WriteLine("Помилка. Введіть коректне значення.");
                } while (check == false || n < 1);
                Console.Clear();
                LibraryUserArr = new LibraryUser[n];
                for (int i = 0; i < n; i++)
                {
                    LibraryUserArr[i] = new LibraryUser();
                    Console.WriteLine($"Користувач бібліотеки {i + 1}");
                    Console.Write("Введіть ім'я: ");
                    LibraryUserArr[i].name = Console.ReadLine();
                    Console.Write("Введіть прізвище: ");
                    LibraryUserArr[i].surname = Console.ReadLine();
                    Console.Write("Введіть дату народження: ");
                    LibraryUserArr[i].birthdayDate = Console.ReadLine();
                    Console.Write("Введіть номер читацького квитка: ");
                    LibraryUserArr[i].readingNumber = Console.ReadLine();
                    Console.Write("Введіть дату видачі: ");
                    LibraryUserArr[i].date = Console.ReadLine();
                    Console.Write("Введіть розмір щомісячного читацького внеску: ");
                    LibraryUserArr[i].payment = float.Parse(Console.ReadLine());
                    Console.Clear();
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Користувач бібліотеки {i + 1}");
                    LibraryUserArr[i].ShowInfo();
                    Console.Write("\n");
                }
                Console.ReadKey();
                break;
            }
        case 0:
            {
                Console.Clear();
                Console.WriteLine("Завершення роботи...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        default:
            {
                Console.Clear();
                Console.WriteLine("Помилка. Введіть коректне значення (від 0 до 5)");
                Console.ReadKey();
                Console.Clear();
                break;
            }
    }
} while (act != 0);