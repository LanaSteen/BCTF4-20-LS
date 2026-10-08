using Microsoft.EntityFrameworkCore;
using School.Domain.Interfaces;
using School.Domain.Models.Entities;
using School.Infrastucture.Data;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace School.Infrastucture.Repositories
{
	public class StudentRepository : IStudentRepository
	{
		private readonly SchoolDbContext _context;
		public StudentRepository(SchoolDbContext context)
		{
			_context = context;
		}

		public async Task<ICollection<Student>> GetAllAsync(CancellationToken cancellationToken = default)
		{
			return await _context.Students.ToListAsync(cancellationToken);
		}

		public async Task<Student?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
		{
			return await _context.Students.FirstOrDefaultAsync(s => s.Id == id,
				cancellationToken);
		}

		public async Task AddAsync(Student student, CancellationToken cancellationToken = default)
		{
			await _context.Students.AddAsync(student, cancellationToken);
			// unit of work pattern is used to save changes in the database
	
		}

		public void Update(Student student)
		{
			_context.Students.Update(student);
		}

		public void Delete(Student student)
		{
			_context.Students.Remove(student);
		}
	}
}
