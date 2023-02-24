namespace SanaCSharp06ClassLibrary;

//Батьківський клас
public class Human
{
    public Date DateOfBirthday { get; set; } //Дата народження
    public string Name { get; set; } //Ім'я
    public string Surname { get; set; } //Прізвище

    //Конструктор по замовчуванню
    public Human()
    {
        Name = "Олег";
        Surname = "Мартинюк";
        DateOfBirthday = new Date(2003, 12, 5, 0, 0);
    }

    //Два конструктори з параметрами 
    public Human(string name, string surname, Date dateOfBirthday)
    {
        Name = name;
        Surname = surname;
        DateOfBirthday = dateOfBirthday;
    }

    public Human(string name, string surname)
    {
        Name = name;
        Surname = surname;
        DateOfBirthday = new Date();
    }

    //Конструктор копіювання
    public Human(Human human)
    {
        Name = human.Name;
        Surname = human.Surname;
        DateOfBirthday = human.DateOfBirthday;
    }

    //Віртуальний метод, який виводить усю доступну інформацію
    public virtual string ShowInfo()
    {
        return $"Ім'я: {Name}\nПрізвище: {Surname}\nДата народження: {DateOfBirthday.ToStringDateShort()}";
    }
}