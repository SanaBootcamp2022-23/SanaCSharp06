using SanaCSharp06_ClassLibrary;


var people = new Person[]
{
    new Person(firstName: "Taras", lastName: "Shevchenko", birthDate: new DateTime(2002, 8, 15)),

    new Applicant(firstName: "Grigoriy", lastName: "Skovoroda", birthDate: new DateTime(2001, 10, 8),
        etScore: 198, educationDocScore:9.5, insitutionName:"School #5"),

    new Student(firstName: "Vasil", lastName: "Stus", birthDate: new DateTime(1999, 9, 7), universityName: "Zhytomyr Polytechnic",
        faculty: "Mechanical Engineering", group: "ME22", studyingYear: 1),

    new Teacher(firstName: "Lina", lastName: "Kostenko", birthDate: new DateTime(1989, 3, 25), 
        universityName: "Zhytomyr Polytechnic", department: "Department of Law"),

    new LibraryUser(firstName: "Olga", lastName: "Kobylyanska", birthDate: new DateTime(1995, 12, 13), 
        libraryTicketID: 148, issueDate: new DateTime(2023, 3, 25), libraryFee: 75)
};

foreach (Person person in people)
{
    person.ShowInfo();  
    Console.WriteLine();
}