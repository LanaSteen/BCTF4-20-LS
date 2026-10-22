using School.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastucture.FileStorage
{
	public class LocalFileStorageServise : IFileStorageService
	{

		private readonly string _basePath;

		public LocalFileStorageServise(string basePath)
		{
			_basePath = basePath;
		}


		public async Task<string> SaveFileAsync
			(
			  Stream stream, string fileName, string contentType, string folder = null,
			  CancellationToken cancellationToken = default
			)
		{
			var extension = Path.GetExtension(fileName);
			var newFileName = $"{Guid.NewGuid()}{extension}";  // dsdsdsd.jpg

			var folderPath = string.IsNullOrEmpty(folder)
				? Path.Combine(_basePath, "uploads")
				: Path.Combine(_basePath, "uploads", folder);

			Directory.CreateDirectory(folderPath);
			var fullPath = Path.Combine(folderPath, newFileName);

			await using var fileStream = new FileStream(fullPath, FileMode.Create);

			await stream.CopyToAsync(fileStream, cancellationToken);

			return string.IsNullOrEmpty(folder)
				? $"/uploads/{newFileName}"
				: $"/uploads/{folder}/{newFileName}";
		}


		public Task DeleteFileAsync(string filePath, CancellationToken cancellationToken = default)
		{
			var fullPath = Path.Combine(_basePath, filePath.TrimStart('/'));
			if (File.Exists(fullPath))
			{
				File.Delete(fullPath);
			}
			return Task.CompletedTask;
		}
	}
}
