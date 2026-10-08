using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Models.Entities
{
	public class Teacher
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public ICollection<Subject> Subjects { get; set; } = new List<Subject>();

	}
}




//1:m