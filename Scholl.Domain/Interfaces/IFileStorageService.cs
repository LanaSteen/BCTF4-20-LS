using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Interfaces
{
	public interface IFileStorageService
	{
		Task<string> SaveFileAsync
			(
			  Stream stream, string fileName, string contentType, string folder = null,
			  CancellationToken cancellationToken = default
			);
		Task DeleteFileAsync(string filePath, CancellationToken cancellationToken = default);
	}
}
