using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using UniversityDomain.Interfaces;
using UniversityDomain.Models;

namespace UniversityInfrastucture.Repositories
{
	public class StudentRepository : IStudentRepository
	{

		private readonly string _connectionString;

		public StudentRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		public IEnumerable<Student> GetAll()
		{
			var students = new List<Student>();

			var query = "SELECT * FROM Students";

			using var connection = new SqlConnection(_connectionString);
			using var command = new SqlCommand(query, connection);
			connection.Open();
			using var reader = command.ExecuteReader();

			while (reader.Read())
			{
				if (reader.HasRows)
				{
					students.Add(MapStudent(reader));
				}

			}

			return students;

		}


		public Student GetById(int id)
		{


			var student = new Student();
			var query = "SELECT * FROM Students where Id = @Id";

			using var connection = new SqlConnection(_connectionString);
			using var command = new SqlCommand(query, connection);
			connection.Open();
			using var reader = command.ExecuteReader();

			if (reader.Read())
			{
				//	//Id = reader.GetInt32(reader.GetOrdinal("Id")),
				//	//FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
				//	//LastName = reader.GetString(reader.GetOrdinal("LastName")),

				//	student.Id = reader.GetInt32(0);
				//	student.FirstName = reader.GetString(1);
				//	student.LastName = reader.GetString(2);
				//	student.Email = reader.GetString(3);
				//	student.Age = reader.GetInt32(4);
				//	student.GPA = reader.IsDBNull(5) ? null : reader.GetDecimal(5);
				//	student.PhoneNumber = reader.IsDBNull(6) ? null : reader.GetString(6);
				//	student.IsActive = reader.IsDBNull(7) ? null : reader.GetBoolean(7);
				//	student.RegisteredAt = reader.IsDBNull(8) ? null : reader.GetDateTime(8);
				//	student.DepartmentId = reader.IsDBNull(9) ? null : reader.GetInt32(9);
				return MapStudent(reader);
			}

			return null;
		}

		public bool Add(Student student)
		{
			throw new NotImplementedException();
		}




		private Student MapStudent(SqlDataReader reader)
		{
			return new Student
			{
				Id = reader.GetInt32(0),
				FirstName = reader.GetString(1),
				LastName = reader.GetString(2),
				Email = reader.GetString(3),
				Age = reader.GetInt32(4),
				GPA = reader.IsDBNull(5) ? null : reader.GetDecimal(5),
				PhoneNumber = reader.IsDBNull(6) ? null : reader.GetString(6),
				IsActive = reader.IsDBNull(7) ? null : reader.GetBoolean(7),
				RegisteredAt = reader.IsDBNull(8) ? null : reader.GetDateTime(8),
				DepartmentId = reader.IsDBNull(9) ? null : reader.GetInt32(9)
			};
		}

	}
}
