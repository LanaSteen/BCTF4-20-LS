using School.Application.Services.Interfaces;
using School.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Services.Implementations
{
	public class StudentProfileService : IStudentProfileService
	{
		private readonly IStudentProfileRepository _studentProfileRepository;
		private readonly IFileStorageService _fileStorageService;
		private readonly IUnitOfWork _unitOfWork;

		public StudentProfileService(IStudentProfileRepository studentProfileRepository, IFileStorageService fileStorageService, IUnitOfWork unitOfWork)
		{
			_studentProfileRepository = studentProfileRepository;
			_fileStorageService = fileStorageService;
			_unitOfWork = unitOfWork;
		}

		public async Task<string> UploadProfilePictureAsync(int studentProfileId, Stream fileStream, string fileName, string contentType, long fileSize, CancellationToken cancellationToken = default)
		{
			if(fileSize <= 0)
			{
				throw new InvalidOperationException("File size must be greater than 0.");
			}	
			if(fileSize > 5 * 1024 * 1024) // 5 MB limit
			{
				throw new InvalidOperationException("File size exceeds the maximum limit of 5 MB.");
			}

			var allowContentTypes = new List<string> { "image/jpeg", "image/png", "image/gif" };
			if(!allowContentTypes.Contains(contentType))
			{
				throw new InvalidOperationException("Invalid file type.");
			}

			var extension = Path.GetExtension(fileName).ToLower();

			string[] allowExtensions = { ".jpg", ".jpeg", ".png", ".gif" };
			if(!allowExtensions.Contains(extension))
			{
				throw new InvalidOperationException("Invalid file extension.");
			}

			var studentProfile = await _studentProfileRepository.GetByIdAsync(studentProfileId, cancellationToken);
			if (studentProfile == null)
			{
				throw new InvalidOperationException("Student profile not found.");
			}

			var oldPhotoUrl = studentProfile.PhotoUrl;

			var newPhotoUrl = await _fileStorageService.SaveFileAsync(fileStream, fileName, contentType, "students", cancellationToken);


			try
			{
				studentProfile.PhotoUrl = newPhotoUrl;

				_studentProfileRepository.Update(studentProfile);
				await _unitOfWork.SaveChangesAsync(cancellationToken);
			}
			catch 
			{
				await _fileStorageService.DeleteFileAsync(newPhotoUrl, cancellationToken);
				throw;
			}

			return newPhotoUrl;
		}
	}

}

