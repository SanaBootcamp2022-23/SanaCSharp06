using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
	public class Person
	{
		public string firstName;
		public string secondName;
		public DateTime dateOfBirth;

		public Person() { }
		public Person(string firstName,string secondName)
		{
			this.firstName = firstName;
			this.secondName = secondName;
		}
		public Person(string firstName, string secondName, DateTime dateOfBirth)
		{
			this.firstName = firstName;
			this.secondName = secondName;
			this.dateOfBirth = dateOfBirth;
		}
		public Person(Person person)
		{
			this.firstName = person.firstName;
			this.secondName = person.secondName;
			this.dateOfBirth = person.dateOfBirth;
		}

		public virtual void ShowInfo()
		{
			Console.WriteLine($"{firstName} {secondName} {dateOfBirth.ToString("yyyy/MM/dd")}");
		}
		public void SetFirstName(string firstName) => this.firstName = firstName;
		public string GetFirstName() => this.firstName;
		
		public void SetSecondName(string secondName) => this.secondName = secondName;
		public string GetSecondName() => this.secondName;

		public void SetDateOfBirth(DateTime date) => this.dateOfBirth = date;
		public DateTime GetDateOfBirth() => this.dateOfBirth;


	}
}