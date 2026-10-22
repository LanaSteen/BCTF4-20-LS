using Microsoft.EntityFrameworkCore;
using School.Domain.Interfaces;
using School.Domain.Models.Entities;
using School.Infrastucture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastucture.Repositories
{
	public class StudentProfileRepository : IStudentProfileRepository
	{
		private readonly SchoolDbContext _context;

		public StudentProfileRepository(SchoolDbContext context)
		{
			_context = context;
		}

		public async Task<StudentProfile?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
		{
			return await _context.StudentProfiles.FirstOrDefaultAsync(sp => sp.Id == id, cancellationToken);
		}

		public void Update(StudentProfile studentProfile)
		{
			_context.StudentProfiles.Update(studentProfile);
		}
	}
}
