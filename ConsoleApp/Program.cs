using Education;

using static System.Console;

List<Human> persons = new()
{
    new Human("Sergiy", "Sergiyenko", new(1995, 11, 3)),
    new Applicant("Igor", "Igorenko", new(2005, 10, 12), "School №1", 9, new() {
        ["Math"] = 192,
        ["Ukr. Lang"] = 178,
        ["History"] = 147
    }),
    new Student("Dmytro", "Dmytrenko", new(2003, 6, 1), 3, "VT-22-2", "FICT", "ZTU"),
    new Teacher("Vasyl", "Vasylenko", new(1975, 1, 17), "KhPI", "SEMIT", "Lector"),
    new LibraryMember("Andriy", "Andriyennko", new(1986, 7, 4), 1, 150)
};

persons.ForEach(person =>
{
  WriteLine();
  person.ShowInfo();
  WriteLine();
});
