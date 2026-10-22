using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Services.Interfaces
{
	public interface IStudentProfileService
	{
		Task<string> UploadProfilePictureAsync(int studentProfileId, Stream fileStream, string fileName, string contentType, long fileSize, CancellationToken cancellationToken = default);

	}
}
