using School.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Models.Entities
{
	public class Student
	{
		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }

		public int StudentProfileId { get; set; }
		public StudentProfile StudentProfile { get; set; }

		public DateTime DateOfBirth { get; set; }

		public ICollection<Enrolment> Enrolments { get; set; } = new List<Enrolment>();

	}
}


//m:m
//Student / Subject