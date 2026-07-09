using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.Json;
using UnivercityCore.Enums;
using UnivercityCore.Interfaces;
using UnivercityCore.Models;

namespace UnivercityRepository
{
	public class FileRepository : IFlieManager
	{
		private readonly string _filePath = "C:\\Users\\l4nst\\Desktop\\doit2026\\BCTF4-20-LS-v1\\UnivercityRepository\\Data\\Students.txt";


		public void AddStudent(Student student)
		{
			string line = JsonSerializer.Serialize(student);
			File.AppendAllLines(_filePath, new[] { line });
		}

		public void DeleteStudent(int id)
		{
			throw new NotImplementedException();
		}

		public List<Student> GetAllStudents()
		{
			string[] lines = File.ReadAllLines(_filePath);
			if (!File.Exists(_filePath))
			{
				return new List<Student>();
			}

			List<Student> students = new List<Student>();

			foreach (var line in lines)
			{
				if(string.IsNullOrWhiteSpace(line))
				{
					continue;
				}
				
				Student student = JsonSerializer.Deserialize<Student>(line);
				students.Add(student);

			}

			return students;

		}

		//"Id" : 1  //  Todo  



		//jSON 

		//{
		//"Id" : 1,
		//"Username" : "dfdfgg656",
		//"Email": "dfdf@fdfdg", "Password": "dfdfgdfg"
		//}	    



		//1,"hjjh",


		public Student GetLastLoggedInStudent()
		{
			List<Student> students = GetAllStudents();
			Student student = students.OrderBy(x => x.LastLogin).LastOrDefault();

			return student;
		}


		public Student GetStudentByEmail(string email)
		{
			List<Student> students = GetAllStudents();
			Student student = students.FirstOrDefault(s => s.Email == email);

			return student;
		}

		public Student GetStudentById(int id)
		{
			List<Student> students = GetAllStudents();
			Student student = students.FirstOrDefault(s => s.Id == id);

			return student;
		}

		public void UpdateStudent(Student student)
		{
			List<Student> students = GetAllStudents();

			int index = students.FindIndex(s => s.Id == student.Id);
			if (index != -1)
			{
				students[index] = student;
			}
			SaveChanges(students);
		}


		public void  SaveChanges(List<Student> students)
		{

			File.Delete(_filePath);
			File.AppendAllLines(_filePath, students.Select(s => JsonSerializer.Serialize(s)));
		}


	}
}
