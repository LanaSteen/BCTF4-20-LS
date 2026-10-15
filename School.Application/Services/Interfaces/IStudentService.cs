using School.Domain.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.ApplicationUser.Services.Interfaces
{
	public interface IStudentService
	{
		Task<ICollection<StudentDTO>> GetAllStudetnsAsync(
			CancellationToken cancellationToken);
		Task<StudentDTO> GetStudentByIdAsync(int id,
			CancellationToken cancellationToken);
		Task<StudentDTO> AddStudentAsync(CreateStudentDTO createStudentDto, CancellationToken cancellationToken);

		Task UpdateStudentAsync(int id, UpdateStudentDTO updateStudentDto, CancellationToken cancellationToken);
		Task DeleteStudentAsync(int id, CancellationToken cancellationToken);
	}
}
