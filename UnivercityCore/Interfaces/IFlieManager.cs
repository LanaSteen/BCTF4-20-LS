using System;
using System.Collections.Generic;
using System.Text;
using UnivercityCore.Models;

namespace UnivercityCore.Interfaces
{
	public interface IFlieManager
	{

		Task<List<Student>> GetAllStudents();

		Task<Student> GetStudentById(int id);
		Task<Student> GetStudentByEmail(string email);

		Task AddStudent(Student student);
		Task UpdateStudent(Student student);
		Task DeleteStudent(int id);

		Task SaveChanges(List<Student> students);
	    Task<Student> GetLastLoggedInStudent();

	}
}
