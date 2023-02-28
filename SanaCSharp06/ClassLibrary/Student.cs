using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Student : Person
	{
		public int course;
		public string group;
		public string faculty;
		public string nameOfUni;

		public Student() { }
		public Student(int course, string group, string faculty, string nameOfUni)
		{
			this.course = course;
			this.group = group;
			this.faculty = faculty;
			this.nameOfUni = nameOfUni;
		}
		public Student(int course, string group, string faculty, string nameOfUni, Person person)
		{
			this.course = course;
			this.group = group;
			this.faculty = faculty;
			this.nameOfUni = nameOfUni;
			firstName = person.firstName;
			secondName = person.secondName;
			dateOfBirth = person.dateOfBirth;
		}
		public Student(Student student)
		{
			this.course = student.course;
			this.group = student.group;
			this.faculty= student.faculty;
			this.firstName= student.firstName;
			this.secondName = student.secondName;
			this.dateOfBirth = student.dateOfBirth;
		}

		public void SetCourse(int course) => this.course=course;
		public int GetCourse() => this.course;

		public void SetGroup(string group) => this.group = group;
		public string GetGroup() => this.group;

		public void SetFaculty(string faculty) => this.faculty = faculty;
		public string GetFaculty() => this.faculty;

		public void SetNameOfUni(string nameOfUni) => this.nameOfUni = nameOfUni;
		public string GetNameOfUni() => this.nameOfUni;

		public override void ShowInfo()
		{
			base.ShowInfo();
			Console.WriteLine($"Група {group} {course}й курс, {faculty}, {nameOfUni}");
		}
	}
}
