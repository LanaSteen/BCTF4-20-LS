using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Models.Entities
{
	public class Enrolment
	{
		public int Id { get; set; }
		public int StudentId { get; set; }

		public Student Student { get; set; }

		public int SubjectId { get; set; }

		public Subject Subject { get; set; }

		public DateTime EnrolmentDate  { get; set; }

	}
}
//  1:m
//	1:m
//	m:m