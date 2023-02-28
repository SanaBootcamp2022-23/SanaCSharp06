namespace ClassLibrary
{
	public class Enrollee : Person
	{
		public double averageZNO;
		public double certificate;
		public string nameOfUni;

		public Enrollee() { }
		public Enrollee(double averageZNO, double certificate, string nameOfUni)
		{
			this.averageZNO = averageZNO;
			this.certificate = certificate;
			this.nameOfUni = nameOfUni;
		}
		public Enrollee(string FirstName, string SecondName, DateTime dateOfBirth,
			double averageZNO, double certificate, string nameOfUni) : base(FirstName, SecondName, dateOfBirth)
		{
			this.averageZNO = averageZNO;
			this.certificate = certificate;
			this.nameOfUni = nameOfUni;
		}
		public Enrollee(double averageZNO, double certificate, string nameOfUni, Person person)
		{
			this.averageZNO = averageZNO;
			this.certificate = certificate;
			this.nameOfUni = nameOfUni;
			firstName = person.firstName;
			secondName = person.secondName;
			dateOfBirth = person.dateOfBirth;
		}
		public void SetAverageZNO(double averageZNO) => this.averageZNO = averageZNO;
		public double GetAverageZNO() => this.averageZNO;

		public void SetCertificate(double certificate) => this.certificate = certificate;
		public double GetCertificate() => this.certificate;

		public void SetNameOfUni(string nameOfUni) => this.nameOfUni = nameOfUni;
		public string GetNameOfUni() => this.nameOfUni;

		public override void ShowInfo()
		{
			base.ShowInfo();
			Console.WriteLine($"Бал ЗНО = {averageZNO}\nБал аттестату = {certificate}\nНазва вишу = {nameOfUni}");
		}
	}
}
