using System;
using System.Collections.Generic;
using System.Text;
using UnivercityCore.Interfaces;
using UnivercityCore.Models;

namespace UnivercityApplication.Implementations
{
	public class StudentService
	{

		private readonly IFlieManager _fileManager;


		//DI
		public StudentService(IFlieManager fileManager)
		{
			_fileManager = fileManager;
		}


		public void RegisterStudent(string username, string email, string password)
		{
			var students = _fileManager.GetAllStudents();
			int idNext = students.Count + 1;

			var existingStudent = _fileManager.GetStudentByEmail(email);
			if (existingStudent != null)
			{
				throw new Exception("A student with this email already exists.");
			}

			string verificationCode = new Random().Next(1000, 9999).ToString(); 

			var newStudent = new Student
			{
				Id = idNext,
				Username = username,
				Email = email,
				Password =  BCrypt.Net.BCrypt.HashPassword(password),   ///password, // /todo  132   fghfhg54gh5gj4gjh6gh5g4jh65
				IsVerified = false,
				VerificationCode = verificationCode //  todo email send
			};
			_fileManager.AddStudent(newStudent);
			//_fileManager.SaveChanges(_fileManager.GetAllStudents());
		}



	}
}
