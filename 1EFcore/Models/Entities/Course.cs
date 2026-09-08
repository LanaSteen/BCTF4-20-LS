using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _1EFcore.Models.Entities
{
	internal class Course
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(100)]
		public string Title { get; set; }

		public ICollection<Student> Students { get; set; }
	}
}
