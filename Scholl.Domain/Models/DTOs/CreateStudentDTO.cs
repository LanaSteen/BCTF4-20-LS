using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School.Domain.Models.DTOs
{
	public class CreateStudentDTO
	{
		///  incapsulation attriibutes
		[Required]
		[StringLength(50)]
		public string FirstName { get; set; } = string.Empty;
		[Required]
		[StringLength(50)]
		public string LastName { get; set; } = string.Empty;
		[Required]
		[StringLength(100)]
		[EmailAddress]
		public string Email { get; set; } = string.Empty;
		[Required]
		public DateTime DateOfBirth { get; set; }
	}
}
