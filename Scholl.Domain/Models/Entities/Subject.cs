using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Models.Entities
{
	public class Subject
	{
		public int Id { get; set; }  // Id // SubjectId
		public string Name { get; set; }
		public string Description { get; set; }

		public int TeacherId { get; set; }
		public Teacher Teacher { get; set; }

		public ICollection<Enrolment> Enrolments { get; set; } = new List<Enrolment>();
	}
}
