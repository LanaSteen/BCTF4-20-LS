using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Models.Entities
{
	public class StudentProfile
	{
		public int Id { get; set; }

		public string  IdentityNumber { get; set; }

		public string? PhotoUrl { get; set; }

		public int StudentId { get; set; } //fk

		public Student Student { get; set; } // navigation property

	}
}
