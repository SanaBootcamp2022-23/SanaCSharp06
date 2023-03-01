using System;

class Human
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Human(string firstName, string lastName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
    }
    public Human(string firstName, DateTime dateOfBirth)
    {
        FirstName = firstName;
        LastName = "Unknown";
        DateOfBirth = dateOfBirth;
    }
    public Human()
    {
    }
    public void ShowInfo()
    {
        Console.WriteLine("----- Human Info -----");
        Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        Console.WriteLine("Date of birth: {0}", DateOfBirth.ToShortDateString());
    }
}