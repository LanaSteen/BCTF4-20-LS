using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Models.Entities
{
	public class StudentProfile
	{
		public int Id { get; set; }

		public string  IdentityNumber { get; set; }

		public int StudentId { get; set; }

		public Student Student { get; set; }

	}
}
