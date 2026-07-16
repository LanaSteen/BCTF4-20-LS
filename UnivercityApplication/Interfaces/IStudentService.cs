using System;
using System.Collections.Generic;
using System.Text;
using UnivercityCore.Models;

namespace UnivercityApplication.Interfaces
{
	public interface IStudentService
	{
		Task RegisterStudent(string username, string email, string password);

		Task<Student> LoginStudent(string username, string password);

		Task SendVerificationCode(string email, string verificationCode);
	}
}
