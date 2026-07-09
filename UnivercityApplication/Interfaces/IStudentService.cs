using System;
using System.Collections.Generic;
using System.Text;
using UnivercityCore.Models;

namespace UnivercityApplication.Interfaces
{
	public interface IStudentService
	{
		void RegisterStudent(string username, string email, string password);

		Student LoginStudent(string username, string password);

		void SendVerificationCode(string email, string verificationCode);
	}
}
