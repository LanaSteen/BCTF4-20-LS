using School.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Models.DTOs
{
	public class StudentDTO
	{

		public int Id { get; set; } 
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public DateTime DateOfBirth { get; set; } 
	}
}
