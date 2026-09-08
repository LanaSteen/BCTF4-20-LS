using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1EFcore.Models.Entities
{
	internal class Student
	{
		
		public int Id { get; set; }
		[Required]
		[MaxLength(100)]
		public string FirstName { get; set; }
		[Required]
		[MaxLength(100)]
		public string LastName { get; set; }

		public string Email { get; set; }
		public string Phone { get; set; }
		public int Age { get; set; }
		public decimal GPA { get; set; }
		public ICollection<Course> Courses { get; set; }
		public StudentProfile Profile { get; set; }
	}
}
