using System.Text;
using UniversityApplication.Services;
using UniversityDomain.Interfaces;
using UniversityDomain.Models;
using UniversityInfrastucture.Repositories;

namespace UniversityPresentation
{
	internal class Program
	{

		private static readonly string _connectionString = "Server=LAPTOP-HE9JLDVE;Database=UNIVERSITY;Trusted_Connection=True; TrustServerCertificate=True;";
		//todo  appsettings.json

		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;
			IStudentRepository studentRepository = new StudentRepository(_connectionString);
			var studentService = new StudentService(studentRepository);

			//Console.WriteLine("All students:");
			//studentService.GetAllStudents();

			//Console.WriteLine("Student by id 1");
			//studentService.GetStudentById(1);


			//Console.WriteLine("Adding a new student:");
			//studentService.AddStudent(new Student { FirstName = "John", LastName = "Doe",  Email = "john.doe@example.com", Age = 20, GPA = 3.5M, PhoneNumber = "123-456-7890", IsActive = true, RegisteredAt = DateTime.Now, DepartmentId = 1 });


			Console.WriteLine("Updating a student:");
			studentService.UpdateStudentGpa(2, 3.9M);

		}
	}
}
