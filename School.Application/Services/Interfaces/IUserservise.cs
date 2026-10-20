using School.Domain.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Services.Interfaces
{
	public interface IUserservise
	{
		Task RegisterUserAsync(RegisterDTO dto, CancellationToken cancellationToken = default);
		//Task<bool> LoginUserAsync(LoginDTO dto, CancellationToken cancellationToken = default);

	}
}
