using Lecture15.Enums;
using Lecture15.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.Models
{
	internal class Student : Person, IPrintable, IComparable<Student>
	{




		public Student(string name, string lastName, int age, string email, string phone, double gPA, Faculty faculty) : base(name, lastName, age)
		{
			Email = email;
			Phone = phone;
			GPA = gPA;
			Faculty = faculty;
		}

		public string Email { get; set; }  /// validatioons

		public string Phone { get; set; }

		public double GPA { get; set; }

		public Faculty Faculty { get; set; }

		public int CompareTo(Student? other)
		{
			return GPA.CompareTo(other.GPA);
		}

		public void Print()
		{
			Console.WriteLine(ToString());
		}

		public override string? ToString()
		{
			return $"Student: {Name} {LastName}, Age: {Age}, Email: {Email}, Phone: {Phone}, GPA: {GPA}, Faculty: {Faculty}";
		}
	}
}
