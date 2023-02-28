using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Teacher : Person
	{
		public string position;
		public string department;
		public string nameOfUni;

		public Teacher() { }

		public Teacher(string position, string department, string nameOfUni)
		{
			this.position = position;
			this.department = department;
			this.nameOfUni = nameOfUni;
		}

		public Teacher(string position, string department, string nameOfUni, Person person) : this(position,department,nameOfUni) {
			this.firstName = person.firstName;
			this.secondName= person.secondName;
			this.dateOfBirth= person.dateOfBirth;
		}
		public Teacher(Teacher teacher)
		{
			this.position = teacher.position;
			this.department= teacher.department;
			this.nameOfUni= teacher.nameOfUni;
			this.firstName= teacher.firstName;
			this.secondName	= teacher.secondName;
			this.dateOfBirth = teacher.dateOfBirth;
		}
		
		public void SetPosition(string position) => this.position = position;
		public string GetPosition() => this.position;

		public void SetDepartment(string department) => this.department = department;
		public string GetDepartment() => this.department;

		public void SetNameOfUni(string nameOfUni) => this.nameOfUni = nameOfUni;
		public string GetNameOfUni() => this.nameOfUni;


		public override void ShowInfo()
		{
			base.ShowInfo();
			Console.WriteLine($"Посада: {position}, кафедра: {department}, {nameOfUni}");
		}
	}
}
