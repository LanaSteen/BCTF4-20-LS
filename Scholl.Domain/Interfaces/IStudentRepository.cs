using School.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Interfaces
{
	public interface IStudentRepository
	{
		Task<ICollection<Student>> GetAllAsync(CancellationToken cancellationToken = default);
		Task<Student?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
		Task AddAsync(Student student, CancellationToken cancellationToken = default);
		void Update(Student student);
		void Delete(Student student);


	}
}
