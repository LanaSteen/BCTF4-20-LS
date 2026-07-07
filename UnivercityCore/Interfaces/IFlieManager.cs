using System;
using System.Collections.Generic;
using System.Text;
using UnivercityCore.Models;

namespace UnivercityCore.Interfaces
{
	public interface IFlieManager
	{

		List<Student> GetAllStudents();

		Student GetStudentById(int id);
		Student GetStudentByEmail(string email);

		void AddStudent(Student student);
		void UpdateStudent(Student student);
		void DeleteStudent(int id);

		void SaveChanges(List<Student> students);

	}
}
