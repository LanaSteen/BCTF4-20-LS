using System;
using System.Collections.Generic;
using System.Text;

namespace _1EFcore.Models.Entities
{
	internal class StudentProfile
	{
		public int Id { get; set; }
		public string Address { get; set; }
		public int StudentId { get; set; }
		public Student Student { get; set; }
	}
}
