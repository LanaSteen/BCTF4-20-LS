using School.Application.Services.Interfaces;
using School.Domain.Interfaces;
using School.Domain.Models.DTOs;
using School.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace School.Application.Services.Implementations
{
	public class StudentService : IStudentService
	{

		private readonly IStudentRepository _studentRepository;
		private readonly IUnitOfWork _unitOfWork;

		public StudentService(IStudentRepository studentRepository,IUnitOfWork unitOfWork)
		{
			_studentRepository = studentRepository;
			_unitOfWork = unitOfWork;
		}


		private static void ValidateStudent(string firstName, string lastName, string email, DateTime dateOfBirth)
		{
			if (string.IsNullOrEmpty(firstName) || firstName.Length > 50)
			{
				throw new ArgumentException("Invalid first name");
			}
			if (string.IsNullOrEmpty(lastName) || lastName.Length > 50)
			{
				throw new ArgumentException("Invalid first name");
			}
			if (string.IsNullOrEmpty(email) || email.Length > 100 ||
				new EmailAddressAttribute().IsValid(email)  == false)
			{
				throw new ArgumentException("Invalid first name");
			}
			if (dateOfBirth == default || dateOfBirth > DateTime.Now)
			{
				throw new ArgumentException("Invalid date of birth");
			}
		}

		private static StudentDTO MapStudentToDTO(Student student)
		{
			return new StudentDTO
			{
				Id = student.Id,
				FirstName = student.FirstName,
				LastName = student.LastName,
				Email = student.Email,
				DateOfBirth = student.DateOfBirth
			};
		}

		public async Task<ICollection<StudentDTO>> GetAllStudetnsAsync(
			CancellationToken cancellationToken)
		{
			var students = await _studentRepository.GetAllAsync(cancellationToken);


			return students
				  .Select(MapStudentToDTO)
				  .ToList();

		}

		public async Task<StudentDTO> GetStudentByIdAsync(int id,
			CancellationToken cancellationToken)
		{
			var student = await _studentRepository.GetByIdAsync(id, cancellationToken);

			if (student == null)
			{
				return null;
  			}

			return MapStudentToDTO(student);

		}




		public async Task<StudentDTO> AddStudentAsync(CreateStudentDTO createStudentDto,CancellationToken cancellationToken)
		{
			var student = new Student
			{
				FirstName = createStudentDto.FirstName,
				LastName = createStudentDto.LastName,
				Email = createStudentDto.Email,
				DateOfBirth = createStudentDto.DateOfBirth
			};

			ValidateStudent(
				createStudentDto.FirstName,
				createStudentDto.LastName,
				createStudentDto.Email,
				createStudentDto.DateOfBirth
				);

			await _studentRepository.AddAsync(student, cancellationToken);
			await _unitOfWork.SaveChangesAsync(cancellationToken);

			return MapStudentToDTO(student);
		}



		public async Task UpdateStudentAsync(int id, UpdateStudentDTO updateStudentDto, CancellationToken cancellationToken)
		{
			var student = await _studentRepository.GetByIdAsync(id, cancellationToken);

			if (student == null)
			{
				throw new KeyNotFoundException("Student not found");
			}

			ValidateStudent(
			updateStudentDto.FirstName,
			updateStudentDto.LastName,
			updateStudentDto.Email,
			updateStudentDto.DateOfBirth
			);

			student.FirstName = updateStudentDto.FirstName;
			student.LastName = updateStudentDto.LastName;
			student.Email = updateStudentDto.Email;
			student.DateOfBirth = updateStudentDto.DateOfBirth;

			_studentRepository.Update(student);
			await _unitOfWork.SaveChangesAsync(cancellationToken);

		}

		public async Task DeleteStudentAsync(int id, CancellationToken cancellationToken)
		{
			var student = await _studentRepository.GetByIdAsync(id, cancellationToken);

			if (student == null)
			{
				throw new KeyNotFoundException("Student not found");
			}

			_studentRepository.Delete(student);
			await _unitOfWork.SaveChangesAsync(cancellationToken);

		}
	
	
	}
}
