using System;
using System.Collections.Generic;
using System.Text;
using UnivercityApplication.Interfaces;
using UnivercityCore.Interfaces;
using UnivercityCore.Models;

namespace UnivercityApplication.Implementations
{
	public class StudentService : IStudentService
	{

		private readonly IFlieManager _fileManager;
		private readonly EmailService _emailService;


		//DI
		public StudentService(IFlieManager fileManager, EmailService emailService)
		{
			_fileManager = fileManager;
			_emailService = emailService;
		}



		public async Task RegisterStudent(string username, string email, string password)
		{
			var students =await _fileManager.GetAllStudents();
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
			SendVerificationCode(email, verificationCode);
			//_fileManager.SaveChanges(_fileManager.GetAllStudents());
		}

		public async Task SendVerificationCode(string email, string verificationCode)
		{
			_emailService.SeedEmail(email, "Verification Code", verificationCode);
		}

		public async Task<bool> VerifyStudent(string email, string verificationCode)
		{
			Student student =await _fileManager.GetStudentByEmail(email);
			if (student == null)
			{
				Console.WriteLine("Student not found.");
				throw new ArgumentException("Student not found.");

			}
			if (student.VerificationCode == verificationCode)
			{
				student.IsVerified = true;
				_fileManager.UpdateStudent(student);
				Console.WriteLine("Verification successful.");
				return true;
			}

			Console.WriteLine("Invalid verification code.");
			return false;
		}



		public async Task<Student> LoginStudent(string email, string password)
		{
			Student st = await _fileManager.GetStudentByEmail(email);
			
			

			if (st != null && st.IsVerified)
			{
				if (BCrypt.Net.BCrypt.Verify(password, st.Password))
				{
					st.LastLogin = DateTime.Now;
					_fileManager.UpdateStudent(st);
					return st;
				}
			}
			throw new Exception("Invalid email or not verified");
		}


		
		public async Task LogoutStudent(string email)
		{
			Student st =await _fileManager.GetStudentByEmail(email);
			st.LastLogin = null;
			_fileManager.UpdateStudent(st);
		}

	}
}
