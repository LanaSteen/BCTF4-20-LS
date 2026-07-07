using System;
using System.Collections.Generic;
using System.Text;
using UnivercityCore.Enums;

namespace UnivercityCore.Models
{
	public class Student
	{
		public int Id { get; set; }
		
		public string Username { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }  // 123


		public string VerificationCode { get; set; }


		public bool IsVerified { get; set; }

		public Roles Role { get; set; } = Roles.Student;

	}
}

