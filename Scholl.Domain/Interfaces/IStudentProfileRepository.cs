using School.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Interfaces
{
	public interface IStudentProfileRepository
	{
		Task<StudentProfile?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
		void Update(StudentProfile studentProfile);
	}
}
