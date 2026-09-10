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
		//[varchar] // todo 
		public string Title { get; set; } //nvarchar(100)

		public ICollection<Student> Students { get; set; }
	}
}
